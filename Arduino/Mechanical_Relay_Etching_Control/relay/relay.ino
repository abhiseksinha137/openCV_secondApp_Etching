int relay_pin=12;
int flagMsg=0;
int command=10;
void setup() {
  // put your setup code here, to run once:
  pinMode(relay_pin, OUTPUT);
  Serial.begin(9600);
}

void loop() 
{
  // put your main code here, to run repeatedly:
  while(!Serial.available()); // wait till data to be filled in serial buffer
  String incommingStr = Serial.readStringUntil('\n'); // read the complete string
  int command=incommingStr.toInt();
  if (command==1)
    relay_on();
  if (command==0)
    relay_off();
}

void relay_on()
{
  digitalWrite(relay_pin, HIGH);
}

void relay_off()
{
  digitalWrite(relay_pin, LOW);
}