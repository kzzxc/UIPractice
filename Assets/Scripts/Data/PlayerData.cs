using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private CharacterSkins _selectedCharacterSkin;
    private MazeSkins _selectedMazeSkin;

    private List<CharacterSkins> _openCharacterSkins;
    private List<MazeSkins> _openMazeSkins;

    private int _money;

    public PlayerData()
    {
        _money = 10000;

        _selectedCharacterSkin = CharacterSkins.Anubis;
        _selectedMazeSkin = MazeSkins.Green;

        _openCharacterSkins = new List<CharacterSkins>() { _selectedCharacterSkin };
        _openMazeSkins = new List<MazeSkins>() { _selectedMazeSkin };
    }

    public int Money
    {
        get => _money;

        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _money = value;
        }
    }

    public CharacterSkins SelectedCharacterSkin
    {
        get => _selectedCharacterSkin;
        
        set
        {
            if (_openCharacterSkins.Contains(value) == false)
                throw new ArgumentException(nameof(value));

            _selectedCharacterSkin = value;
        }
    }

    public MazeSkins SelectedMazeSkin
    {
        get => _selectedMazeSkin;

        set
        {
            if (_openMazeSkins.Contains(value) == false)
                throw new ArgumentException(nameof(value));
        }
    }

    public IEnumerable<CharacterSkins> OpenCharacterSkins => _openCharacterSkins;

    public IEnumerable<MazeSkins> OpenMazeSkins => _openMazeSkins;
}
