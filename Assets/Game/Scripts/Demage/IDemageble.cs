using System;

public interface IDemageble
{
    void TakeDemage(int demage);
    event Action DemageEvent;
}
