#define ARDUINO 2
#define TRANSMIT_LED 13
#define LDR_PIN A0
#define LDR_ENABLE 2
#define SAMPLING_TIME 7

#define RESET 9

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

//Reset and Baudrate
int BaudRate = 0;
char Check = 126;

//Calibration
int LDRMax;
int LDRMin;
int LDRAvg;

void setup() {
  // put your setup code here, to run once:
  digitalWrite(RESET, HIGH);
  pinMode(RESET, OUTPUT);
  pinMode(TRANSMIT_LED, OUTPUT);
  digitalWrite(LDR_ENABLE, HIGH); // Turn the LDR on
  Serial.begin(9600);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for Native USB only
  }
  Calibrate();
}

void loop() {

  if (BaudRate == 2) {
    digitalWrite(RESET, LOW);
    delay(100);
  }
  if (BaudRate > 5) {
    //Serial.println("Flushing");
    Serial.flush();
    Serial.begin(BaudRate);
    BaudRate = 1;
  }

  // LED
  if (Serial.available()) {
    if (BaudRate == 1) {
      while (Serial.available()) {
        character = Serial.read();
        if (character == Check) {
          BaudRate = 2;
        }
        text.concat(character);
      }
      LED();
    }
    else if (BaudRate == 0) {
      BaudRate = Serial.parseInt();
    }
  }

  // LDR
  if (BaudRate == 1) {
    LDR();
  }
}

void LED()
{
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

void Calibrate()
{
  if (ARDUINO == 2)
  {
    delay(25);
  }
  while (LDRMax - LDRMin < 5)
  {
    digitalWrite(TRANSMIT_LED, HIGH); //Return to IDLE state
    delay(50);
    LDRMax = analogRead(LDR_PIN);
    delay(50);
    digitalWrite(TRANSMIT_LED, LOW); //Return to IDLE state
    delay(50);
    LDRMin = analogRead(LDR_PIN);
    delay(50);
    if (ARDUINO == 2)
    {
      delay(6);
    }
  }
  for (int i = 0; i < 4; i++)
  {
    digitalWrite(TRANSMIT_LED, HIGH); //Return to IDLE state
    delay(50);
    delay(50);
    digitalWrite(TRANSMIT_LED, LOW); //Return to IDLE state
    delay(50);
    delay(50);
  }
  LDRAvg = ((LDRMax + LDRMin) / 2);
  digitalWrite(TRANSMIT_LED, HIGH); //Return to IDLE state
//  Serial.println(LDRMax);
//  Serial.println(LDRMin);
//  Serial.println(LDRAvg);
}

void LDR()
{
  current_state = get_ldr();
  if (!current_state && previous_state)
  {
    sprintf(buff, "%c", get_byte());
    if (strcmp(buff, "~") == 0) {
      BaudRate = 2;
    }
    Serial.print(buff);
  }
  previous_state = current_state;
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
  bool val = analogRead(LDR_PIN) > LDRAvg ? true : false;
  return val;
}

char get_byte()
{
  char data_byte = 0;
  delay(SAMPLING_TIME * 1.5);
  for (int i = 0; i < 8; i++)
  {
    data_byte = data_byte | (char)get_ldr() << i;
    delay(SAMPLING_TIME);
  }
  return data_byte;
}
