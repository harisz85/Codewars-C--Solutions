using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;







Task

Given an interface IDuck, you are to create an Object Adapter (using Composition) in order to adapt the Goose class to support the IDuck interface.
IDuck Interface

public interface IDuck
{
    string Quack();
    void Fly();
}

Goose Class

public class Goose
{
    string Honk();
    void Fly();
}

----------------------------------------------------------------------------------


public class GooseToIDuckAdapter : IDuck
{
    private Goose _goose;

    public GooseToIDuckAdapter(Goose goose)
    {
        _goose = goose;
    }

    public string Quack()
    {

        return _goose.Honk();
    }


    public void Fly()
    {

        _goose.Fly();
    }
}