WashingMachine myWashingMachine = new WashingMachine(10.5);

myWashingMachine.OpenPorthole();

try
{
    myWashingMachine.LoadWashingMachine(11);
}
catch (Exception ex) { 
    Console.WriteLine(ex.Message);
}

myWashingMachine.ClosePorthole();

try
{
    myWashingMachine.LoadWashingMachine(5);
}
catch (Exception ex) {
    Console.WriteLine(ex.Message);
}

float currentCharge = myWashingMachine.GetCurrentChargeWeight();

myWashingMachine.OpenPorthole();

try
{
    myWashingMachine.LoadWashingMachine(5);
} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}