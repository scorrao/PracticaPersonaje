public class Personaje
{
    public string Color { get; set; }
    public int Vida {get; set; }
    public int Mana {get; set; }
    public int Fuerza {get; set; }
    public int Defensa {get; set; }


    public void CambiarColor(string color)
    {
        Color = color;
    }

    public int RecibirDanio(int fuerzaAtaque){
        int DanioEfectivo = fuerzaAtaque - Defensa;
        if (DanioEfectivo < 0)
        {
            DanioEfectivo = 0;
        }
        Vida = Vida - DanioEfectivo;
        //Vida -= DanioEfectivo;
        return DanioEfectivo;
    }
    public int Atacar(Personaje objetivo)
    {
        if (Mana >= 10)
        {
            Mana -= 10;
            int DanioEfectivo = objetivo.RecibirDanio(Fuerza);
            return DanioEfectivo;
            //return objetivo.RecibirDanio(Fuerza);
        }
        else
        {
            return 0;
        }
    }
}