using System;
using System.Collections.Generic;
using System.Text;

namespace OOP____01_Assignment
{
    internal struct DeliveryCenter
    {
        private Shipment[] _shipments;

        public DeliveryCenter()
        {
            _shipments = new Shipment[10];
        }

        public Shipment this[int index] 
        {
            get
            {
                if (_shipments is not null && index >=0 && index < _shipments.Length)
                {
                    return _shipments[index];
                }
                else return default;
            }

            set
            {
                if (_shipments is not null && index >=0 &&index < _shipments.Length)
                {
                    _shipments[index] = value;
                }
            } 
        }


        public Shipment this[string trackingCode] 
        {
            get
            {
                if (_shipments is not null)
                {
                    for (int i = 0; i < _shipments.Length; i++)
                    {
                        if (_shipments[i].TrackingCode == trackingCode)
                        {
                            return _shipments[i];
                        }
                    }
                }
                return default;
            }
        }

        public bool AddShipment(Shipment ship)
        {
            if (_shipments is null) return false;
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i].TrackingCode == null)
                {
                    _shipments[i] = ship;
                    return true;
                }
            }
            return false;
        }


    }
}
