#include <SoftwareSerial.h>

SoftwareSerial mySerial(10, 11); // RX, TX
char Input;
int BaudRate = 0;
int Reset = 9;
char Check = 126;

void setup()
{
  digitalWrite(Reset, HIGH);
  pinMode(Reset, OUTPUT);
  // Open serial communications and wait for port to open:
  Serial.begin(9600);
  while (!Serial) {
    // wait for serial port to connect. Needed for Native USB only
  }
}

void loop() // run over and over
{
  if (BaudRate > 1) {
    //Serial.println("Flushing");
    Serial.flush();
    mySerial.begin(BaudRate);
    Serial.begin(BaudRate);
    BaudRate = 1;
  }
  if (Serial.available()) {
    if (BaudRate == 1) {
      Input = Serial.read();
      //Serial.println("Reading");
      if (Input == Check) {
        digitalWrite(Reset, LOW);
        delay(1000);
      }
      else {
        //Serial.println("Writing");
        mySerial.write(Input);
      }
    }
    else if (BaudRate == 0) {
      //Serial.println("BaudRate");
      BaudRate = Serial.parseInt();
    }

  }
  if (mySerial.available()) {
    //Serial.println("Relaying");
    Serial.write(mySerial.read());
  }
}
