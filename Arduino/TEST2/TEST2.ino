#define LDR_PIN A0
#define SAMPLING_TIME 20
#define LDR_ENABLE 2



//Declaration
bool led_state = false;
bool previous_state = true;
bool current_state = true;
char buff[64];
void setup() 
{
  Serial.begin(9600);
  digitalWrite(LDR_ENABLE, HIGH); // Turn the LDR on
  
}

void loop() 
{
  current_state = get_ldr(); 
  if(!current_state && previous_state)
  {
    sprintf(buff, "%c", get_byte());
    Serial.print(buff);
  }
  previous_state = current_state;
  
}
bool get_ldr()
{
  bool val = analogRead(LDR_PIN) > 0 ? true : false;
  //Serial.println(val);
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
