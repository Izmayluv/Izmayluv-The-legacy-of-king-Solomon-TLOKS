 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pers1 : MonoBehaviour
{float[,] x=new float[5,5];
float[,] y=new float[5,5];
float[,] sc=new float[5,5];
float[] z=new float[5];
    public static int f=1;
    public static    int x1=3;
    public static    int y1=2;
    public Sprite sprite1;
    public Sprite sprite2;
        public Sprite sprite3;
            public Sprite sprite4;
float xp,yp,scp;
float xt,yt,sct;
private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
      {spriteRenderer = GetComponent<SpriteRenderer>();
        z[0]=-2000f;
        z[1]=-2200f;
        z[2]=-2400f;
        z[3]=-2600f;
        z[4]=-2800f;
sc[0,0]=21.6f;  sc[1,0]=21.8f;  sc[2,0]=22f;    sc[3,0]=22.2f;  sc[4,0]=22.4f;
sc[0,1]=23.3f;  sc[1,1]=23.5f;  sc[2,1]=23.4f;  sc[3,1]=23.6f;  sc[4,1]=24f;
sc[0,2]=24.7f;  sc[1,2]=25f;    sc[2,2]=24.8f;  sc[3,2]=25f;    sc[4,2]=25.4f;
sc[0,3]=26.6f;  sc[1,3]=26.3f;  sc[2,3]=26.4f;  sc[3,3]=26.5f;  sc[4,3]=27f;
sc[0,4]=28.5f;  sc[1,4]=28f;    sc[2,4]=28.2f;  sc[3,4]=28.5f;  sc[4,4]=29f;

x[0,0]=-612f;   x[1,0]=-486.7f; x[2,0]=-359f;   x[3,0]=-231f;   x[4,0]=-103.6f;
x[0,1]=-651.1f; x[1,1]=-516f;   x[2,1]=-382f;   x[3,1]=-247f;   x[4,1]=-111f;
x[0,2]=-693f;   x[1,2]=-551f;   x[2,2]=-407f;   x[3,2]=-264f;   x[4,2]=-120f;
x[0,3]=-741.3f; x[1,3]=-588f;   x[2,3]=-435.9f; x[3,3]=-283f;   x[4,3]=-130f;
x[0,4]=-797f;   x[1,4]=-632.8f; x[2,4]=-468f;   x[3,4]=-306f;   x[4,4]=-141f;

y[0,0]=97f;     y[1,0]=94f;     y[2,0]=95f;     y[3,0]=96f;     y[4,0]=97.4f;
y[0,1]=38.3f;   y[1,1]=39f;     y[2,1]=36f;     y[3,1]=37f;     y[4,1]=40f;
y[0,2]=-27.4f;  y[1,2]=-29f;    y[2,2]=-30f;    y[3,2]=-29f;    y[4,2]=-28f;
y[0,3]=-104f;   y[1,3]=-105f;   y[2,3]=-106f;   y[3,3]=-102f;   y[4,3]=-102f;
y[0,4]=-191f;   y[1,4]=-194.7f; y[2,4]=-189.5f; y[3,4]=-191f;   y[4,4]=-191f;
  xp=x[x1,y1];yp=y[x1,y1];scp=sc[x1,y1];
        transform.localPosition=new Vector3(x[x1,y1],y[x1,y1],z[y1]);
      this.transform.localScale = new Vector3(sc[x1,y1],sc[x1,y1],sc[x1,y1]);
      }
int equip=1,faza=0;
    // Update is called once per frame
    void Update()
      {
        if(pers2.q==1){
          if (Input.GetKeyDown("e")){faza=1;}
          if (faza==1){
              if (Input.GetKeyDown("1"))
              {
                  equip=1;
                  spriteRenderer.sprite = sprite1;
                  faza=0;
              }
              if (Input.GetKeyDown("2"))
              {
                  equip=2;
                  spriteRenderer.sprite = sprite2;
                  faza=0;
              }
              if (Input.GetKeyDown("3"))
              {
                  equip=3;
                  spriteRenderer.sprite = sprite3;
                  faza=0;
              }
              if (Input.GetKeyDown("4"))
              {
                  equip=4;
                  spriteRenderer.sprite = sprite4;
                  faza=0;
              }
            }
        if (Input.GetKeyDown("w"))
          {if (f==1){
          StartCoroutine(presup());
          }}
          if (Input.GetKeyDown("s"))
          {if (f==1){
          StartCoroutine(presdown());
          }}
            if (Input.GetKeyDown("a"))
            {if (f==1){
            StartCoroutine(presleft());
            }}
              if (Input.GetKeyDown("d"))
              {if (f==1){
              StartCoroutine(presright());
              }}
              }
      }
      IEnumerator presup()
          {
             if ((y1>=1)&&((y1-1!=pers2.y1)||(x1!=pers2.x1)))
              {f=0;
                int y1t=y1;
                y1--;
                xt=(x[x1,y1]-x[x1,y1t])/32.0f;
                yt=(y[x1,y1]-y[x1,y1t])/32.0f;
                sct=(sc[x1,y1]-sc[x1,y1t])/32.0f;
                for (int i=0;i<32;i++){
yield return new WaitForSeconds(0.005f);
                  scp+=sct;
                  xp+=xt;
                  yp+=yt;
                transform.localPosition=new Vector3(xp,yp,z[y1]);
                      this.transform.localScale = new Vector3(scp,scp,scp);
              }
              xp=x[x1,y1];yp=y[x1,y1];scp=sc[x1,y1];
              transform.localPosition=new Vector3(xp,yp,z[y1]);
                    this.transform.localScale = new Vector3(scp,scp,scp);
                    f=1;
            }

          }
          IEnumerator presdown()
              {
                 if ((y1<=3)&&((y1+1!=pers2.y1)||(x1!=pers2.x1)))
                  {f=0;
                    int y1t=y1;
                    y1++;
                    xt=(x[x1,y1]-x[x1,y1t])/32.0f;
                    yt=(y[x1,y1]-y[x1,y1t])/32.0f;
                    sct=(sc[x1,y1]-sc[x1,y1t])/32.0f;
                    for (int i=0;i<32;i++){
    yield return new WaitForSeconds(0.005f);
                      scp+=sct;
                      xp+=xt;
                      yp+=yt;
                    transform.localPosition=new Vector3(xp,yp,z[y1]);
                          this.transform.localScale = new Vector3(scp,scp,scp);
                  }
                  xp=x[x1,y1];yp=y[x1,y1];scp=sc[x1,y1];
                  transform.localPosition=new Vector3(xp,yp,z[y1]);
                        this.transform.localScale = new Vector3(scp,scp,scp);
                        f=1;
                }

              }
                IEnumerator presleft()
                {
                  if ((x1>=1)&&((x1-1!=pers2.x1)||(y1!=pers2.y1)))
                   {f=0;
                     int x1t=x1;
                     x1--;
                     xt=(x[x1,y1]-x[x1t,y1])/32.0f;
                     yt=(y[x1,y1]-y[x1t,y1])/32.0f;
                     sct=(sc[x1,y1]-sc[x1t,y1])/32.0f;
                     for (int i=0;i<32;i++){
     yield return new WaitForSeconds(0.005f);
                       scp+=sct;
                       xp+=xt;
                       yp+=yt;
                     transform.localPosition=new Vector3(xp,yp,z[y1]);
                           this.transform.localScale = new Vector3(scp,scp,scp);
                   }
                   xp=x[x1,y1];yp=y[x1,y1];scp=sc[x1,y1];
                   transform.localPosition=new Vector3(xp,yp,z[y1]);
                         this.transform.localScale = new Vector3(scp,scp,scp);
                         f=1;
                 }
                }
                IEnumerator presright()
                {
                  if ((x1<=3)&&((x1+1!=pers2.x1)||(y1!=pers2.y1)))
                   {f=0;
                     int x1t=x1;
                     x1++;
                     xt=(x[x1,y1]-x[x1t,y1])/32.0f;
                     yt=(y[x1,y1]-y[x1t,y1])/32.0f;
                     sct=(sc[x1,y1]-sc[x1t,y1])/32.0f;
                     for (int i=0;i<32;i++){
     yield return new WaitForSeconds(0.005f);
                       scp+=sct;
                       xp+=xt;
                       yp+=yt;
                     transform.localPosition=new Vector3(xp,yp,z[y1]);
                           this.transform.localScale = new Vector3(scp,scp,scp);
                   }
                   xp=x[x1,y1];yp=y[x1,y1];scp=sc[x1,y1];
                   transform.localPosition=new Vector3(xp,yp,z[y1]);
                         this.transform.localScale = new Vector3(scp,scp,scp);
                         f=1;
                 }
                }
  }
