using UnityEngine;
using System.Collections;

public class Boss
{
    int mp = 53;
    
    public void Magic(int a)
    {
        int num = mp - a;
                
        this.mp -= a;
        
        if (num >= 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + num);
                    
        }else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
        
    }


}

public class MagicTack : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Boss lastboss = new Boss();

        for(int i=1; i <= 11; i++)
        {
            lastboss.Magic(5);
        }

        

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
