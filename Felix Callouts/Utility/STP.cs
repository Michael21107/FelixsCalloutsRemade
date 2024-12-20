﻿using Rage;
using Rage.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixsCallouts
{
    public class STP
    {
        public static void SetPedDrunk(Ped Ped, bool state)
        {
            if (Main.Debug_Mode) Game.LogTrivial("STP - Set Drunk");
            StopThePed.API.Functions.setPedAlcoholOverLimit(Ped, state);
        }

        public static void SetPedUnderDrugInfluence(Ped Ped, bool state)
        {
            if (Main.Debug_Mode) Game.LogTrivial("STP - Set Drunk");
            StopThePed.API.Functions.setPedUnderDrugsInfluence(Ped, state);
        }

        public static void SetVehicleInsurance(Vehicle Veh, StopThePed.API.STPVehicleStatus state)
        {
            if (Main.Debug_Mode) Game.LogTrivial("STP - Set Drunk");
            StopThePed.API.Functions.setVehicleInsuranceStatus(Veh, state);
        }

        public static void SetVehicleRegistration(Vehicle Veh, StopThePed.API.STPVehicleStatus state)
        {
            if (Main.Debug_Mode) Game.LogTrivial("STP - Set Drunk");
            StopThePed.API.Functions.setVehicleRegistrationStatus(Veh, state);
        }
    }
}
