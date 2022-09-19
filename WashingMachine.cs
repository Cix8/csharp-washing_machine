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
            throw new Exception("Devi prima aprire l'oblò altrimenti non posso caricare la lavatrice");
        } else
        {
            if(this.currentChargeWeight + weight < this.maxChargeKg)
            {
                this.currentChargeWeight += (float)weight;
            } else
            {
                throw new Exception("Il peso totale supera il peso massimo consentito, prova con un qualcosa di meno pesante...");
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
            throw new Exception("Devi prima chiudere l'oblò!");
        } else if (this.currentChargeWeight == 0)
        {
            throw new Exception("Il cestello è vuoto!");
        } else if (!this.soapAdded)
        {
            throw new Exception("Non hai aggiunto il sapone...");
        } else if (this.coldMode)
        {
            throw new Exception("Il programma è impostato su 'lavaggio a freddo' mentre si sta cercando di avviare il lavaggio a caldo...");
        } else
        {
            this.loadedCorrectly = true;
            this.OutOfSoap();
        }
    }

    public void StartColdWash()
    {
        this.loadedCorrectly = false;
        if (this.openPorthole)
        {
            throw new Exception("Devi prima chiudere l'oblò!");
        }
        else if (this.currentChargeWeight == 0)
        {
            throw new Exception("Il cestello è vuoto!");
        }
        else if (!this.soapAdded)
        {
            throw new Exception("Non hai aggiunto il sapone...");
        }
        else if (!this.coldMode)
        {
            throw new Exception("Il programma è impostato su 'lavaggio a caldo' mentre si sta cercando di avviare il lavaggio a freddo...");
        }
        else
        {
            this.loadedCorrectly = true;
            this.OutOfSoap();
        }
    }
}
