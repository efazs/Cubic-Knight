using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Creation : MonoBehaviour {

	public GameObject tiles;
	public Material []color;
	private Transform tileTransform;
	private GameObject[,] allTiles = new GameObject[8, 8];
	private GameObject currentTile;
	public List<GameObject> Available;


	int xx;
	int yy;

    int tx, ty;
	// Use this for initialization
	void Start () {
        Spawn_Tiles();
        xx = (int)Random.Range(0,8);
		yy = (int)Random.Range(0,8);

        tx = (int)Random.Range(0, 8);
        ty = (int)Random.Range(0, 8);
        if(xx==tx & yy==ty)
        {
            tx++;
            ty++;
        }

        HighliteTiles(xx,yy);
        transform.position = currentTile.transform.position;
	}
	

	public void Spawn_Tiles()
	{
		
		for (int i = 0; i < 8; i++) {
			for (int j = 0; j < 8; j++) {
					GameObject at = Instantiate (tiles) as GameObject;
					at.transform.Translate(i*2,0,j*2);
					if (i % 2 == 0) {
						at.GetComponent<MeshRenderer>().material = color[j%2];

					}
					else{
						at.GetComponent<MeshRenderer>().material = color[(j+1)%2];
					}
					allTiles[i,j] = at;
				}

		}


	}
	public void HighliteTiles(int x, int y)
	{
        colors();
        if(x==tx && y== ty)
        {
            SceneManager.LoadScene("end");
            
        }

        Available.Clear();
		currentTile = allTiles[x, y];
		if (x + 2 < 8 && y + 1 < 8)
		{
            allTiles[x + 2, y + 1].GetComponent<MeshRenderer>().material = color[2];
            Available.Add(allTiles[x + 2, y + 1]);
           
        }
		if (x + 1 < 8 && y + 2 < 8)
		{
            allTiles[x + 1, y + 2].GetComponent<MeshRenderer>().material = color[2];
            Available.Add(allTiles[x + 1, y + 2]);
		}
		if (x + 2 < 8 && y - 1 > -1)
		{
            allTiles[x + 2, y - 1].GetComponent<MeshRenderer>().material = color[2];
            Available.Add(allTiles[x + 2, y - 1]);
		}
		if (x - 1 > -1 && y + 2 < 8)
		{
            allTiles[x - 1, y + 2].GetComponent<MeshRenderer>().material = color[2];
            Available.Add(allTiles[x - 1, y + 2]);
		}
		if (x - 2 > -1 && y + 1 < 8)
		{
            allTiles[x - 2, y + 1].GetComponent<MeshRenderer>().material = color[2];
            Available.Add(allTiles[x - 2, y + 1]);
		}
		if (x - 2 > -1 && y - 1 > -1)
		{
            allTiles[x - 2, y - 1].GetComponent<MeshRenderer>().material = color[2];
            Available.Add(allTiles[x - 2, y - 1]);
		}
		if (x + 1 < 8 && y - 2 > -1)
		{
            allTiles[x + 1, y - 2].GetComponent<MeshRenderer>().material = color[2];
            Available.Add(allTiles[x + 1, y - 2]);
		}
		if (x - 1 >-1 && y -2  > -1)
		{
            allTiles[x-1, y - 2].GetComponent<MeshRenderer>().material = color[2];
            Available.Add(allTiles[x - 1, y - 2]);
		}
        allTiles[tx, ty].GetComponent<MeshRenderer>().material = color[3];
    }
    void colors()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                //GameObject at = Instantiate(tiles) as GameObject;
                //at.transform.Translate(i * 2, 0, j * 2);
                if (i % 2 == 0)
                {
                    allTiles[i, j].GetComponent<MeshRenderer>().material = color[j % 2];

                }
                else
                {
                    allTiles[i, j].GetComponent<MeshRenderer>().material = color[(j + 1) % 2];
                }

                
                //allTiles[i, j] = at;
            }
        }
    }

    public void reset()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
