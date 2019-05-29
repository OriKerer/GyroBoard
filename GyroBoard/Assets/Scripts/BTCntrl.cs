using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TechTweaking.Bluetooth;


public class BTCntrl : MonoBehaviour
{

    private static BluetoothDevice device;
    // Start is called before the first frame update
    void Start()
    {
        BluetoothAdapter.enableBluetooth(); // Force Enabling Bluetooth
        BTCntrl.device = new BluetoothDevice();
        device.Name = "HC-05"; // arduino needs to be paired with that name
        //device.MacAddress = "98:D3:32:31:1D:57"; Use only one! name or mac!

        /*
        * 10 equals the char '\n' which is a "new Line" in Ascci representation, 
        * so the read() method will retun a packet thvisuat was ended by the byte 10. simply read() will read lines.
        * If you don't use the setEndByte() method, device.read() will return any available data (line or not), then you can order them as you want.
        */
        device.setEndByte((byte)';');
        device.connect();
    }

    // Update is called once per frame
    void Update()
    {

    }

    static public Vector3 ReadAxisFromBTDevice()
    {
        Vector3 axis = new Vector3();

        if (true || device.IsDataAvailable)
        {
            byte[] msg = device.read();//because we called setEndByte(10)..read will always return a packet excluding the last byte 10.

            if (msg != null && msg.Length > 0)
            {
                string content = System.Text.ASCIIEncoding.ASCII.GetString(msg);
                //debugText.text = content; // print to debug text
                var splitContent = content.Split(',');

                for (int i = 0; i < 3; i++)
                {
                    axis[i] = float.Parse(splitContent[i]);
                }
            }
        }
        return axis;
    }
}
