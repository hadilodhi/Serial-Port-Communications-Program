#define TRANSMIT_LED 13
#define SAMPLING_TIME 20

#define LDR_PIN A0
#define SAMPLING_TIME 20
#define LDR_ENABLE 2

//Declaration

//LED
bool led_state = false;
bool transmit_data = true;
int bytes_counter;
int total_bytes;
String text = "";
char character;

//LDR
bool previous_state = true;
bool current_state = true;
char buff[64];
int Initial;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(TRANSMIT_LED, OUTPUT);
  digitalWrite(TRANSMIT_LED, HIGH); //Return to IDLE state
  digitalWrite(LDR_ENABLE, HIGH); // Turn the LDR on
  delay(1000);
  Initial = analogRead(LDR_PIN) - 3;
  while (!Serial) {
    ; // wait for serial port to connect. Needed for Native USB only
  }
}

void loop() {

//  int val2 = analogRead(LDR_PIN);
//  Serial.println(val2);

// LDR
  current_state = get_ldr();
  if (!current_state && previous_state)
  {
    sprintf(buff, "%c", get_byte());
    Serial.print(buff);
  }
  previous_state = current_state;

// LED
  if (Serial.available()) {
    while (Serial.available()) {
      character = Serial.read();
      text.concat(character);
    }
    total_bytes = text.length();
    transmit_data = true;
    bytes_counter = total_bytes;
    while (transmit_data)
    {
      transmit_byte(text[total_bytes - bytes_counter]);
      bytes_counter--;
      if (bytes_counter == 0)
      {
        transmit_data = false;
      }
    }
    text = "";
  }
}

void transmit_byte(char data_byte)
{
  digitalWrite(TRANSMIT_LED, LOW);
  delay(SAMPLING_TIME);
  for (int i = 0; i < 8; i++)
  {
    digitalWrite(TRANSMIT_LED, (data_byte >> i) & 0x01);
    delay(SAMPLING_TIME);
  }
  digitalWrite(TRANSMIT_LED, HIGH); //Return to IDLE state
  delay(SAMPLING_TIME);
}

bool get_ldr()
{
  bool val = analogRead(LDR_PIN) > Initial ? true : false;
  return val;
}

char get_byte()
{
  char data_byte = 0;
  delay(SAMPLING_TIME * 1.5);
  for(int i = 0; i < 8; i++)
  {
    data_byte = data_byte | (char)get_ldr() << i;
    delay(SAMPLING_TIME);
  }
  return data_byte;
}
