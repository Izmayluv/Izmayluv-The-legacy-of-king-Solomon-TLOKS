using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pers2 : MonoBehaviour
{
    float[,] x = new float[5, 5];
    float[,] y = new float[5, 5];
    float[,] sc = new float[5, 5];
    float[] z = new float[5];
    public static int f = 1;
    public static int x1 = 1;
    public static int y1 = 2;
    public Sprite sprite1;
    public Sprite sprite2;
    float xp, yp, scp;
    float xt, yt, sct;
    public Transform parent;
    private SpriteRenderer spriteRenderer;
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        z[0] = -2000f;
        z[1] = -2200f;
        z[2] = -2400f;
        z[3] = -2600f;
        z[4] = -2800f;
        sc[0, 0] = 21.6f; sc[1, 0] = 21.8f; sc[2, 0] = 22f; sc[3, 0] = 22.2f; sc[4, 0] = 22.4f;
        sc[0, 1] = 23.3f; sc[1, 1] = 23.5f; sc[2, 1] = 23.4f; sc[3, 1] = 23.6f; sc[4, 1] = 24f;
        sc[0, 2] = 24.7f; sc[1, 2] = 25f; sc[2, 2] = 24.8f; sc[3, 2] = 25f; sc[4, 2] = 25.4f;
        sc[0, 3] = 26.6f; sc[1, 3] = 26.3f; sc[2, 3] = 26.4f; sc[3, 3] = 26.5f; sc[4, 3] = 27f;
        sc[0, 4] = 28.5f; sc[1, 4] = 28f; sc[2, 4] = 28.2f; sc[3, 4] = 28.5f; sc[4, 4] = 29f;

        x[0, 0] = -612f; x[1, 0] = -486.7f; x[2, 0] = -359f; x[3, 0] = -231f; x[4, 0] = -103.6f;
        x[0, 1] = -651.1f; x[1, 1] = -516f; x[2, 1] = -382f; x[3, 1] = -247f; x[4, 1] = -111f;
        x[0, 2] = -693f; x[1, 2] = -551f; x[2, 2] = -407f; x[3, 2] = -264f; x[4, 2] = -120f;
        x[0, 3] = -741.3f; x[1, 3] = -588f; x[2, 3] = -435.9f; x[3, 3] = -283f; x[4, 3] = -130f;
        x[0, 4] = -797f; x[1, 4] = -632.8f; x[2, 4] = -468f; x[3, 4] = -306f; x[4, 4] = -141f;

        y[0, 0] = 97f; y[1, 0] = 94f; y[2, 0] = 95f; y[3, 0] = 96f; y[4, 0] = 97.4f;
        y[0, 1] = 38.3f; y[1, 1] = 39f; y[2, 1] = 36f; y[3, 1] = 37f; y[4, 1] = 40f;
        y[0, 2] = -27.4f; y[1, 2] = -29f; y[2, 2] = -30f; y[3, 2] = -29f; y[4, 2] = -28f;
        y[0, 3] = -104f; y[1, 3] = -105f; y[2, 3] = -106f; y[3, 3] = -102f; y[4, 3] = -102f;
        y[0, 4] = -191f; y[1, 4] = -194.7f; y[2, 4] = -189.5f; y[3, 4] = -191f; y[4, 4] = -191f;
        xp = x[x1, y1]; yp = y[x1, y1]; scp = sc[x1, y1];
        transform.localPosition = new Vector3(x[x1, y1], y[x1, y1], z[y1]);
        this.transform.localScale = new Vector3(sc[x1, y1], sc[x1, y1], sc[x1, y1]);
    }


    public int numel = 0;

    public static int q = 0;
    int[] el = new int[4];
    GameObject D;
    GameObject D1;
    GameObject D2;
    GameObject D3;
    GameObject D4;
    GameObject D5;
    public GameObject Darkness;
    public GameObject Darkness1;
    public GameObject Darkness2;
    public GameObject Darkness3;
    public GameObject Darkness4;
    public GameObject Darkness5;
    public GameObject Lighting;
    public GameObject Lighting1;
    public GameObject Lighting2;
    public GameObject Lighting3;
    public GameObject Lighting4;
    public GameObject Lighting5;
    public GameObject Fire;
    public GameObject Fire1;
    public GameObject Fire2;
    public GameObject Fire3;
    public GameObject Fire4;
    public GameObject Fire5;
    public GameObject Earth;
    public GameObject Earth1;
    public GameObject Earth2;
    public GameObject Earth3;
    public GameObject Earth4;
    public GameObject Earth5;
    public GameObject Water;
    public GameObject Water1;
    public GameObject Water2;
    public GameObject Water3;
    public GameObject Water4;
    public GameObject Water5;
    public GameObject Wind;
    public GameObject Wind1;
    public GameObject Wind2;
    public GameObject Wind3;
    public GameObject Wind4;
    public GameObject Wind5;
    int equip = 1, faza = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            if (q == 0)
            {
                q = 1;
            }
            else
            {
                q = 0;
            }
        }
        if (q == 0)
        {
            if (Input.GetKeyDown("e"))
            {
                faza = 1;
            }
            if (Input.GetKeyDown("c"))
            {
                faza = 2;
            }
            if (faza == 1)
            {
                if (Input.GetKeyDown("1"))
                {
                    equip = 1;
                    spriteRenderer.sprite = sprite1;
                    faza = 0;
                }
                if (Input.GetKeyDown("2"))
                {
                    equip = 2;
                    spriteRenderer.sprite = sprite2;
                    faza = 0;
                }
            }
            if ((faza == 2) && ((Input.GetKeyDown("2")) || (Input.GetKeyDown("1")) || (Input.GetKeyDown("3")) || (Input.GetKeyDown("4")) || (Input.GetKeyDown("5")) || (Input.GetKeyDown("6"))))
            {



                if (numel == 3)
                {
                    Destroy(D);
                    Destroy(D1);
                    Destroy(D2);
                    if (el[0] == 4)
                    {
                        D = (GameObject)Instantiate(Water, parent);
                    }
                    if (el[0] == 5)
                    {
                        D = (GameObject)Instantiate(Earth, parent);
                    }
                    if (el[0] == 6)
                    {
                        D = (GameObject)Instantiate(Wind, parent);
                    }
                    if (el[1] == 4)
                    {
                        D1 = (GameObject)Instantiate(Water2, parent);
                    }
                    if (el[1] == 5)
                    {
                        D1 = (GameObject)Instantiate(Earth2, parent);
                    }
                    if (el[1] == 6)
                    {
                        D1 = (GameObject)Instantiate(Wind2, parent);
                    }
                    if (el[2] == 4)
                    {
                        D2 = (GameObject)Instantiate(Water3, parent);
                    }
                    if (el[2] == 5)
                    {
                        D2 = (GameObject)Instantiate(Earth3, parent);
                    }
                    if (el[2] == 6)
                    {
                        D2 = (GameObject)Instantiate(Wind3, parent);
                    }
                    if (el[0] == 2)
                    {
                        D = (GameObject)Instantiate(Lighting, parent);
                    }
                    if (el[1] == 2)
                    {
                        D1 = (GameObject)Instantiate(Lighting2, parent);
                    }
                    if (el[2] == 2)
                    {
                        D2 = (GameObject)Instantiate(Lighting3, parent);
                    }
                    if (el[0] == 1)
                    {
                        D = (GameObject)Instantiate(Darkness, parent);
                    }
                    if (el[1] == 1)
                    {
                        D1 = (GameObject)Instantiate(Darkness2, parent);
                    }
                    if (el[2] == 1)
                    {
                        D2 = (GameObject)Instantiate(Darkness3, parent);
                    }
                    if (el[0] == 3)
                    {
                        D = (GameObject)Instantiate(Fire, parent);
                    }
                    if (el[1] == 3)
                    {
                        D1 = (GameObject)Instantiate(Fire2, parent);
                    }
                    if (el[2] == 3)
                    {
                        D2 = (GameObject)Instantiate(Fire3, parent);
                    }
                    if (Input.GetKeyDown("1"))
                    {
                        el[3] = 1;
                        D3 = (GameObject)Instantiate(Darkness4, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("2"))
                    {
                        el[3] = 2;
                        D3 = (GameObject)Instantiate(Lighting4, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("3"))
                    {
                        el[3] = 3;
                        D3 = (GameObject)Instantiate(Fire4, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("4"))
                    {
                        el[3] = 4;
                        D3 = (GameObject)Instantiate(Water4, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("5"))
                    {
                        el[3] = 5;
                        D3 = (GameObject)Instantiate(Earth4, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("6"))
                    {
                        el[3] = 6;
                        D3 = (GameObject)Instantiate(Wind4, parent);
                        numel++;
                        faza = 0;
                    }
                }
                if (numel == 2)
                {
                    Destroy(D);
                    Destroy(D1);
                    if (el[0] == 4)
                    {
                        D = (GameObject)Instantiate(Water1, parent);
                    }
                    if (el[0] == 5)
                    {
                        D = (GameObject)Instantiate(Earth1, parent);
                    }
                    if (el[0] == 6)
                    {
                        D = (GameObject)Instantiate(Wind1, parent);
                    }
                    if (el[1] == 4)
                    {
                        D1 = (GameObject)Instantiate(Water3, parent);
                    }
                    if (el[1] == 5)
                    {
                        D1 = (GameObject)Instantiate(Earth3, parent);
                    }
                    if (el[1] == 6)
                    {
                        D1 = (GameObject)Instantiate(Wind3, parent);
                    }
                    if (el[0] == 2)
                    {
                        D = (GameObject)Instantiate(Lighting1, parent);
                    }
                    if (el[1] == 2)
                    {
                        D1 = (GameObject)Instantiate(Lighting3, parent);
                    }
                    if (el[0] == 1)
                    {
                        D = (GameObject)Instantiate(Darkness1, parent);
                    }
                    if (el[1] == 1)
                    {
                        D1 = (GameObject)Instantiate(Darkness3, parent);
                    }
                    if (el[0] == 3)
                    {
                        D = (GameObject)Instantiate(Fire1, parent);
                    }
                    if (el[1] == 3)
                    {
                        D1 = (GameObject)Instantiate(Fire3, parent);
                    }
                    if (Input.GetKeyDown("1"))
                    {
                        el[2] = 1;
                        D2 = (GameObject)Instantiate(Darkness5, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("2"))
                    {
                        el[2] = 2;
                        D2 = (GameObject)Instantiate(Lighting5, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("3"))
                    {
                        el[2] = 3;
                        D2 = (GameObject)Instantiate(Fire5, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("4"))
                    {
                        el[2] = 4;
                        D2 = (GameObject)Instantiate(Water5, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("5"))
                    {
                        el[2] = 5;
                        D2 = (GameObject)Instantiate(Earth5, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("6"))
                    {
                        el[2] = 6;
                        D2 = (GameObject)Instantiate(Wind5, parent);
                        numel++;
                        faza = 0;
                    }
                }
                if (numel == 1)
                {
                    Destroy(D);
                    if (el[0] == 4)
                    {
                        D = (GameObject)Instantiate(Water, parent);
                    }
                    if (el[0] == 5)
                    {
                        D = (GameObject)Instantiate(Earth, parent);
                    }
                    if (el[0] == 6)
                    {
                        D = (GameObject)Instantiate(Wind, parent);
                    }

                    if (el[0] == 2)
                    {
                        D = (GameObject)Instantiate(Lighting, parent);
                    }
                    if (el[0] == 1)
                    {
                        D = (GameObject)Instantiate(Darkness, parent);
                    }
                    if (el[0] == 3)
                    {
                        D = (GameObject)Instantiate(Fire, parent);
                    }
                    if (Input.GetKeyDown("1"))
                    {
                        el[1] = 1;
                        D1 = (GameObject)Instantiate(Darkness3, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("2"))
                    {
                        el[1] = 2;
                        D1 = (GameObject)Instantiate(Lighting3, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("3"))
                    {
                        el[1] = 3;
                        D1 = (GameObject)Instantiate(Fire3, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("4"))
                    {
                        el[1] = 4;
                        D1 = (GameObject)Instantiate(Water3, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("5"))
                    {
                        el[1] = 5;
                        D1 = (GameObject)Instantiate(Earth3, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("6"))
                    {
                        el[1] = 6;
                        D1 = (GameObject)Instantiate(Wind3, parent);
                        numel++;
                        faza = 0;
                    }
                }
                if (numel == 0)
                {
                    if (Input.GetKeyDown("1"))
                    {
                        el[0] = 1;
                        D = (GameObject)Instantiate(Darkness, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("2"))
                    {
                        el[0] = 2;
                        D = (GameObject)Instantiate(Lighting, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("3"))
                    {
                        el[0] = 3;
                        D = (GameObject)Instantiate(Fire, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("4"))
                    {
                        el[0] = 4;
                        D = (GameObject)Instantiate(Water, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("5"))
                    {
                        el[0] = 5;
                        D = (GameObject)Instantiate(Earth, parent);
                        numel++;
                        faza = 0;
                    }
                    if (Input.GetKeyDown("6"))
                    {
                        el[0] = 6;
                        D = (GameObject)Instantiate(Wind, parent);
                        numel++;
                        faza = 0;
                    }

                }

            }
            if (Input.GetKeyDown("w"))
            {
                if (f == 1)
                {
                    StartCoroutine(presup());
                }
            }
            if (Input.GetKeyDown("s"))
            {
                if (f == 1)
                {
                    StartCoroutine(presdown());
                }
            }
            if (Input.GetKeyDown("a"))
            {
                if (f == 1)
                {
                    StartCoroutine(presleft());
                }
            }
            if (Input.GetKeyDown("d"))
            {
                if (f == 1)
                {
                    StartCoroutine(presright());
                }
            }

        }
    }
    IEnumerator presup()
    {
        if ((y1 >= 1) && ((y1 - 1 != pers1.y1) || (x1 != pers1.x1)))
        {
            f = 0;
            int y1t = y1;
            y1--;
            xt = (x[x1, y1] - x[x1, y1t]) / 32.0f;
            yt = (y[x1, y1] - y[x1, y1t]) / 32.0f;
            sct = (sc[x1, y1] - sc[x1, y1t]) / 32.0f;
            for (int i = 0; i < 32; i++)
            {
                yield return new WaitForSeconds(0.005f);
                scp += sct;
                xp += xt;
                yp += yt;
                this.transform.localScale = new Vector3(scp, scp, scp);
                transform.localPosition = new Vector3(xp, yp, z[y1]);
            }
            xp = x[x1, y1]; yp = y[x1, y1]; scp = sc[x1, y1];
            transform.localPosition = new Vector3(xp, yp, z[y1]);
            this.transform.localScale = new Vector3(scp, scp, scp);
            f = 1;
        }

    }
    IEnumerator presdown()
    {
        if ((y1 <= 3) && ((y1 + 1 != pers1.y1) || (x1 != pers1.x1)))
        {
            f = 0;
            int y1t = y1;
            y1++;
            xt = (x[x1, y1] - x[x1, y1t]) / 32.0f;
            yt = (y[x1, y1] - y[x1, y1t]) / 32.0f;
            sct = (sc[x1, y1] - sc[x1, y1t]) / 32.0f;
            for (int i = 0; i < 32; i++)
            {
                yield return new WaitForSeconds(0.005f);
                scp += sct;
                xp += xt;
                yp += yt;
                transform.localPosition = new Vector3(xp, yp, z[y1]);
                this.transform.localScale = new Vector3(scp, scp, scp);
            }
            xp = x[x1, y1]; yp = y[x1, y1]; scp = sc[x1, y1];
            transform.localPosition = new Vector3(xp, yp, z[y1]);
            this.transform.localScale = new Vector3(scp, scp, scp);
            f = 1;
        }

    }
    IEnumerator presleft()
    {
        if ((x1 >= 1) && ((x1 - 1 != pers1.x1) || (y1 != pers1.y1)))
        {
            f = 0;
            int x1t = x1;
            x1--;
            xt = (x[x1, y1] - x[x1t, y1]) / 32.0f;
            yt = (y[x1, y1] - y[x1t, y1]) / 32.0f;
            sct = (sc[x1, y1] - sc[x1t, y1]) / 32.0f;
            for (int i = 0; i < 32; i++)
            {
                yield return new WaitForSeconds(0.005f);
                scp += sct;
                xp += xt;
                yp += yt;
                transform.localPosition = new Vector3(xp, yp, z[y1]);
                this.transform.localScale = new Vector3(scp, scp, scp);
            }
            xp = x[x1, y1]; yp = y[x1, y1]; scp = sc[x1, y1];
            transform.localPosition = new Vector3(xp, yp, z[y1]);
            this.transform.localScale = new Vector3(scp, scp, scp);
            f = 1;
        }
    }
    IEnumerator presright()
    {
        if ((x1 <= 3) && ((x1 + 1 != pers1.x1) || (y1 != pers1.y1)))
        {
            f = 0;
            int x1t = x1;
            x1++;
            xt = (x[x1, y1] - x[x1t, y1]) / 32.0f;
            yt = (y[x1, y1] - y[x1t, y1]) / 32.0f;
            sct = (sc[x1, y1] - sc[x1t, y1]) / 32.0f;
            for (int i = 0; i < 32; i++)
            {
                yield return new WaitForSeconds(0.005f);
                scp += sct;
                xp += xt;
                yp += yt;
                transform.localPosition = new Vector3(xp, yp, z[y1]);
                this.transform.localScale = new Vector3(scp, scp, scp);
            }
            xp = x[x1, y1]; yp = y[x1, y1]; scp = sc[x1, y1];
            transform.localPosition = new Vector3(xp, yp, z[y1]);
            this.transform.localScale = new Vector3(scp, scp, scp);
            f = 1;
        }
    }
}
