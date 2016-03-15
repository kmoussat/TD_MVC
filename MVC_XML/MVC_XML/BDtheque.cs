using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BDtheque
{

    private List<BandeDessinee> bds;

    public BDtheque()
    {
        //pointe vers la nouvelle liste
        this.bds = new List<BandeDessinee>();
    }

    public void Ajouter(BandeDessinee bd)
    {
        //ajoute une bande dessinee à la liste
        bds.Add(bd);
    }

    public BandeDessinee Recuperer(int emplacement)
    {
        //recupere une bd à un emplacement donné
        BandeDessinee getbds = bds.ElementAt(emplacement);
        return getbds;
    }

    public int NombreBandesDessinees()
    {
      
        //retourne le nombre de BD
        return bds.Count;
    }

    override public string ToString()
    {
      
        string retour = "";
        for (int i = 0; i < bds.Count; i++)
        {
            BandeDessinee getbds = bds.ElementAt(i);
            retour += getbds.ToString();
            retour += "\n ";
        }
        return retour;
    }
    
}
