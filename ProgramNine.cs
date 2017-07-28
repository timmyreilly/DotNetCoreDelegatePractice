using System;
using System.Collections.Generic;

class CowTwo
{
    // each of these take 4 bytes - lots of wasted space 

    private Dictionary<string, EventHandler> subscribers = new Dictionary<string, EventHandler>();

    const string BeginMooKey = "BeginMooKey";
    public event EventHandler Moo;
    public event EventHandler BeginMoo
    {
        add
        {
            addSubscriber(BeginMooKey, value); 
        }
        remove
        {
            if (!subscribers.ContainsKey(BeginMooKey))
            {
                return;
            }
            else
            {
                subscribers[BeginMooKey] -= value;
                if (subscribers[BeginMooKey] == null)
                {
                    subscribers.Remove(BeginMooKey);
                }
            }
        }
        // store the subscribing 
    }

    void addSubscriber(string key, EventHandler subscriber)
    {
        if (subscribers.ContainsKey(BeginMooKey))
                subscribers[BeginMooKey] += subscriber;
            else
                subscribers.Add(BeginMooKey, subscriber);
    }
    public event EventHandler EndMoo;

    public event EventHandler Walk;
    public event EventHandler BeginWalking;
    public event EventHandler EndWalking;

    public event EventHandler Sleeping;
    public event EventHandler BeginSleeping;
    public event EventHandler EndSleeping;


}

class MainClassNine
{


    static void MainB()
    {

    }
}