﻿using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private double endurance;

    public Soldier(string name, int age, double experience, double endurance)
    {
        Name = name;
        Age = age;
        Experience = experience;
        this.endurance = endurance;
    }

    public IDictionary<string, IAmmunition> Weapons { get; }
    
    protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    public string Name { get; }

    public int Age { get; }

    public double Experience { get; }

    public double Endurance { get; }

    public double OverallSkill { get; }

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;
    }

    private void AmmunitionRevision(double missionWearLevelDecrement)
    {
        IEnumerable<string> keys = this.Weapons.Keys.ToList();
        foreach (string weaponName in keys)
        {
            this.Weapons[weaponName].DecreaseWearLevel(missionWearLevelDecrement);

            if (this.Weapons[weaponName].WearLevel <= 0)
            {
                this.Weapons[weaponName] = null;
            }
        }
    }

    public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);

    public void Regenerate()
    {
        throw new NotImplementedException();
    }

    public void CompleteMission(IMission mission)
    {
        throw new NotImplementedException();
    }

    internal bool CanCarryWeaponsTotalWeight(List<Ammunition> missionWeapons)
    {
        throw new NotImplementedException();
    }
}