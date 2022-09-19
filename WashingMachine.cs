public class WashingMachine
{
    private bool openPorthole;
    private bool loadedCorrectly;
    private float currentChargeWeight;
    private float maxChargeKg;
    private bool coldMode;
    private bool soapAdded;

    public WashingMachine(double maxChargeKd)
    {
        this.openPorthole = false;
        this.loadedCorrectly = false;
        this.currentChargeWeight = 0;
        this.maxChargeKg = (float)maxChargeKd;
        this.coldMode = false;
        this.soapAdded = false;
    }

    public float GetCurrentChargeWeight()
    {
        return this.currentChargeWeight;
    }

    public void LoadWashingMachine(double weight)
    {
        if(!this.openPorthole)
        {
            Console.WriteLine("Devi prima aprire l'oblò altrimenti non posso caricare la lavatrice");
        } else
        {
            if(this.currentChargeWeight + weight < this.maxChargeKg)
            {
                this.currentChargeWeight += (float)weight;
            } else
            {
                Console.WriteLine("Peso massimo di carica raggiunto!!!");
            }
        }
    }

    public bool GetPortholeStatus()
    {
        return this.openPorthole;
    }

    public void OpenPorthole()
    {
        this.openPorthole = true;
    }

    public void ClosePorthole()
    {
        this.openPorthole = false;
    }

    public void ActivateColdMode()
    {
        this.coldMode = true;
    }

    public void ActivateHotMode()
    {
        this.coldMode = false;
    }

    public void AddSoap()
    {
        this.soapAdded = true;
    }

    private void OutOfSoap()
    {
        this.soapAdded = false;
    }

    public void StartHotWash()
    {
        this.loadedCorrectly = false;
        if(this.openPorthole)
        {
            Console.WriteLine("Devi prima chiudere l'oblò!");
        } else if (this.currentChargeWeight == 0)
        {
            Console.WriteLine("Il cestello è vuoto!");
        } else if (!this.soapAdded)
        {
            Console.WriteLine("Non hai aggiunto il sapone...");
        } else if (this.coldMode)
        {
            Console.WriteLine("Il programma è impostato su 'lavaggio a freddo' mentre si sta cercando di avviare il lavaggio a caldo...");
        } else
        {
            this.loadedCorrectly = true;
            Console.WriteLine("Programma di lavaggio a caldo avviato correttamente");
            this.OutOfSoap();
        }
    }

    public void StartColdWash()
    {
        this.loadedCorrectly = false;
        if (this.openPorthole)
        {
            Console.WriteLine("Devi prima chiudere l'oblò!");
        }
        else if (this.currentChargeWeight == 0)
        {
            Console.WriteLine("Il cestello è vuoto!");
        }
        else if (!this.soapAdded)
        {
            Console.WriteLine("Non hai aggiunto il sapone...");
        }
        else if (!this.coldMode)
        {
            Console.WriteLine("Il programma è impostato su 'lavaggio a caldo' mentre si sta cercando di avviare il lavaggio a freddo...");
        }
        else
        {
            this.loadedCorrectly = true;
            Console.WriteLine("Programma di lavaggio a freddo avviato correttamente");
            this.OutOfSoap();
        }
    }
}

//
