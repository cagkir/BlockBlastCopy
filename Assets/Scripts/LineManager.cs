using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    public GameObject[] Row1, Row2, Row3, Row4, Row5, Row6, Row7, Row8;
    public GameObject[] Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8;
    public Boolean scandone = false;
    public Boolean toScan = false;

    int forrow1 = 0;
    int forrow2 = 0;
    int forrow3 = 0;
    int forrow4 = 0;
    int forrow5 = 0;
    int forrow6 = 0;
    int forrow7 = 0;
    int forrow8 = 0;

    int forColumn1 = 0;
    int forColumn2 = 0;
    int forColumn3 = 0;
    int forColumn4 = 0;
    int forColumn5 = 0;
    int forColumn6 = 0;
    int forColumn7 = 0;
    int forColumn8 = 0;

    public GameObject Manager;


    public void Update()
    {
        if (toScan)
        {
            scandone = false;
            foreach (var item in Row1)
            {
                if (item.layer == 6)
                {
                    forrow1 += 1;
                }
                else
                {
                    forrow1 = 0;
                }
                if (forrow1 == 8)
                {
                    foreach (var item3 in Column1)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn1 += 1;
                        }
                        else
                        {
                            forColumn1 = 0;
                        }
                        if (forColumn1 == 8)
                        {
                            foreach (var item1 in Column1)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column2)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn2 += 1;
                        }
                        else
                        {
                            forColumn2 = 0;
                        }
                        if (forColumn2 == 8)
                        {
                            foreach (var item1 in Column2)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column3)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn3 += 1;
                        }
                        else
                        {
                            forColumn3 = 0;
                        }
                        if (forColumn3 == 8)
                        {
                            foreach (var item1 in Column3)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column4)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn4 += 1;
                        }
                        else
                        {
                            forColumn4 = 0;
                        }
                        if (forColumn4 == 8)
                        {
                            foreach (var item1 in Column4)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column5)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn5 += 1;
                        }
                        else
                        {
                            forColumn5 = 0;
                        }
                        if (forColumn5 == 8)
                        {
                            foreach (var item1 in Column5)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column6)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn6 += 1;
                        }
                        else
                        {
                            forColumn6 = 0;
                        }
                        if (forColumn6 == 8)
                        {
                            foreach (var item1 in Column6)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column7)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn7 += 1;
                        }
                        else
                        {
                            forColumn7 = 0;
                        }
                        if (forColumn7 == 8)
                        {
                            foreach (var item1 in Column7)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column8)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn8 += 1;
                        }
                        else
                        {
                            forColumn8 = 0;
                        }
                        if (forColumn8 == 8)
                        {
                            foreach (var item1 in Column8)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }
                    foreach (var item1 in Row1)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Row2)
            {
                if (item.layer == 6)
                {
                    forrow2 += 1;
                }
                else
                {
                    forrow2 = 0;
                }
                if (forrow2 == 8)
                {
                    foreach (var item3 in Column1)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn1 += 1;
                        }
                        else
                        {
                            forColumn1 = 0;
                        }
                        if (forColumn1 == 8)
                        {
                            foreach (var item1 in Column1)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column2)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn2 += 1;
                        }
                        else
                        {
                            forColumn2 = 0;
                        }
                        if (forColumn2 == 8)
                        {
                            foreach (var item1 in Column2)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column3)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn3 += 1;
                        }
                        else
                        {
                            forColumn3 = 0;
                        }
                        if (forColumn3 == 8)
                        {
                            foreach (var item1 in Column3)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column4)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn4 += 1;
                        }
                        else
                        {
                            forColumn4 = 0;
                        }
                        if (forColumn4 == 8)
                        {
                            foreach (var item1 in Column4)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column5)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn5 += 1;
                        }
                        else
                        {
                            forColumn5 = 0;
                        }
                        if (forColumn5 == 8)
                        {
                            foreach (var item1 in Column5)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column6)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn6 += 1;
                        }
                        else
                        {
                            forColumn6 = 0;
                        }
                        if (forColumn6 == 8)
                        {
                            foreach (var item1 in Column6)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column7)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn7 += 1;
                        }
                        else
                        {
                            forColumn7 = 0;
                        }
                        if (forColumn7 == 8)
                        {
                            foreach (var item1 in Column7)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column8)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn8 += 1;
                        }
                        else
                        {
                            forColumn8 = 0;
                        }
                        if (forColumn8 == 8)
                        {
                            foreach (var item1 in Column8)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }
                    foreach (var item1 in Row2)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Row3)
            {
                if (item.layer == 6)
                {
                    forrow3 += 1;
                }
                else
                {
                    forrow3 = 0;
                }
                if (forrow3 == 8)
                {
                    foreach (var item3 in Column1)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn1 += 1;
                        }
                        else
                        {
                            forColumn1 = 0;
                        }
                        if (forColumn1 == 8)
                        {
                            foreach (var item1 in Column1)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column2)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn2 += 1;
                        }
                        else
                        {
                            forColumn2 = 0;
                        }
                        if (forColumn2 == 8)
                        {
                            foreach (var item1 in Column2)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column3)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn3 += 1;
                        }
                        else
                        {
                            forColumn3 = 0;
                        }
                        if (forColumn3 == 8)
                        {
                            foreach (var item1 in Column3)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column4)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn4 += 1;
                        }
                        else
                        {
                            forColumn4 = 0;
                        }
                        if (forColumn4 == 8)
                        {
                            foreach (var item1 in Column4)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column5)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn5 += 1;
                        }
                        else
                        {
                            forColumn5 = 0;
                        }
                        if (forColumn5 == 8)
                        {
                            foreach (var item1 in Column5)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column6)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn6 += 1;
                        }
                        else
                        {
                            forColumn6 = 0;
                        }
                        if (forColumn6 == 8)
                        {
                            foreach (var item1 in Column6)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column7)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn7 += 1;
                        }
                        else
                        {
                            forColumn7 = 0;
                        }
                        if (forColumn7 == 8)
                        {
                            foreach (var item1 in Column7)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column8)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn8 += 1;
                        }
                        else
                        {
                            forColumn8 = 0;
                        }
                        if (forColumn8 == 8)
                        {
                            foreach (var item1 in Column8)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }
                    foreach (var item1 in Row3)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Row4)
            {
                if (item.layer == 6)
                {
                    forrow4 += 1;
                }
                else
                {
                    forrow4 = 0;
                }
                if (forrow4 == 8)
                {
                    foreach (var item3 in Column1)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn1 += 1;
                        }
                        else
                        {
                            forColumn1 = 0;
                        }
                        if (forColumn1 == 8)
                        {
                            foreach (var item1 in Column1)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column2)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn2 += 1;
                        }
                        else
                        {
                            forColumn2 = 0;
                        }
                        if (forColumn2 == 8)
                        {
                            foreach (var item1 in Column2)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column3)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn3 += 1;
                        }
                        else
                        {
                            forColumn3 = 0;
                        }
                        if (forColumn3 == 8)
                        {
                            foreach (var item1 in Column3)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column4)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn4 += 1;
                        }
                        else
                        {
                            forColumn4 = 0;
                        }
                        if (forColumn4 == 8)
                        {
                            foreach (var item1 in Column4)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column5)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn5 += 1;
                        }
                        else
                        {
                            forColumn5 = 0;
                        }
                        if (forColumn5 == 8)
                        {
                            foreach (var item1 in Column5)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column6)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn6 += 1;
                        }
                        else
                        {
                            forColumn6 = 0;
                        }
                        if (forColumn6 == 8)
                        {
                            foreach (var item1 in Column6)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column7)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn7 += 1;
                        }
                        else
                        {
                            forColumn7 = 0;
                        }
                        if (forColumn7 == 8)
                        {
                            foreach (var item1 in Column7)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column8)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn8 += 1;
                        }
                        else
                        {
                            forColumn8 = 0;
                        }
                        if (forColumn8 == 8)
                        {
                            foreach (var item1 in Column8)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }
                    foreach (var item1 in Row4)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Row5)
            {
                if (item.layer == 6)
                {
                    forrow5 += 1;
                }
                else
                {
                    forrow5 = 0;
                }
                if (forrow5 == 8)
                {
                    foreach (var item3 in Column1)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn1 += 1;
                        }
                        else
                        {
                            forColumn1 = 0;
                        }
                        if (forColumn1 == 8)
                        {
                            foreach (var item1 in Column1)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column2)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn2 += 1;
                        }
                        else
                        {
                            forColumn2 = 0;
                        }
                        if (forColumn2 == 8)
                        {
                            foreach (var item1 in Column2)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column3)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn3 += 1;
                        }
                        else
                        {
                            forColumn3 = 0;
                        }
                        if (forColumn3 == 8)
                        {
                            foreach (var item1 in Column3)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column4)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn4 += 1;
                        }
                        else
                        {
                            forColumn4 = 0;
                        }
                        if (forColumn4 == 8)
                        {
                            foreach (var item1 in Column4)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column5)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn5 += 1;
                        }
                        else
                        {
                            forColumn5 = 0;
                        }
                        if (forColumn5 == 8)
                        {
                            foreach (var item1 in Column5)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column6)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn6 += 1;
                        }
                        else
                        {
                            forColumn6 = 0;
                        }
                        if (forColumn6 == 8)
                        {
                            foreach (var item1 in Column6)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column7)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn7 += 1;
                        }
                        else
                        {
                            forColumn7 = 0;
                        }
                        if (forColumn7 == 8)
                        {
                            foreach (var item1 in Column7)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column8)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn8 += 1;
                        }
                        else
                        {
                            forColumn8 = 0;
                        }
                        if (forColumn8 == 8)
                        {
                            foreach (var item1 in Column8)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }
                    foreach (var item1 in Row5)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Row6)
            {
                if (item.layer == 6)
                {
                    forrow6 += 1;
                }
                else
                {
                    forrow6 = 0;
                }
                if (forrow6 == 8)
                {
                    foreach (var item3 in Column1)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn1 += 1;
                        }
                        else
                        {
                            forColumn1 = 0;
                        }
                        if (forColumn1 == 8)
                        {
                            foreach (var item1 in Column1)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column2)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn2 += 1;
                        }
                        else
                        {
                            forColumn2 = 0;
                        }
                        if (forColumn2 == 8)
                        {
                            foreach (var item1 in Column2)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column3)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn3 += 1;
                        }
                        else
                        {
                            forColumn3 = 0;
                        }
                        if (forColumn3 == 8)
                        {
                            foreach (var item1 in Column3)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column4)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn4 += 1;
                        }
                        else
                        {
                            forColumn4 = 0;
                        }
                        if (forColumn4 == 8)
                        {
                            foreach (var item1 in Column4)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column5)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn5 += 1;
                        }
                        else
                        {
                            forColumn5 = 0;
                        }
                        if (forColumn5 == 8)
                        {
                            foreach (var item1 in Column5)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column6)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn6 += 1;
                        }
                        else
                        {
                            forColumn6 = 0;
                        }
                        if (forColumn6 == 8)
                        {
                            foreach (var item1 in Column6)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column7)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn7 += 1;
                        }
                        else
                        {
                            forColumn7 = 0;
                        }
                        if (forColumn7 == 8)
                        {
                            foreach (var item1 in Column7)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column8)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn8 += 1;
                        }
                        else
                        {
                            forColumn8 = 0;
                        }
                        if (forColumn8 == 8)
                        {
                            foreach (var item1 in Column8)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }
                    foreach (var item1 in Row6)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Row7)
            {
                if (item.layer == 6)
                {
                    forrow7 += 1;
                }
                else
                {
                    forrow7 = 0;
                }
                if (forrow7 == 8)
                {
                    foreach (var item3 in Column1)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn1 += 1;
                        }
                        else
                        {
                            forColumn1 = 0;
                        }
                        if (forColumn1 == 8)
                        {
                            foreach (var item1 in Column1)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column2)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn2 += 1;
                        }
                        else
                        {
                            forColumn2 = 0;
                        }
                        if (forColumn2 == 8)
                        {
                            foreach (var item1 in Column2)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column3)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn3 += 1;
                        }
                        else
                        {
                            forColumn3 = 0;
                        }
                        if (forColumn3 == 8)
                        {
                            foreach (var item1 in Column3)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column4)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn4 += 1;
                        }
                        else
                        {
                            forColumn4 = 0;
                        }
                        if (forColumn4 == 8)
                        {
                            foreach (var item1 in Column4)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column5)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn5 += 1;
                        }
                        else
                        {
                            forColumn5 = 0;
                        }
                        if (forColumn5 == 8)
                        {
                            foreach (var item1 in Column5)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column6)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn6 += 1;
                        }
                        else
                        {
                            forColumn6 = 0;
                        }
                        if (forColumn6 == 8)
                        {
                            foreach (var item1 in Column6)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column7)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn7 += 1;
                        }
                        else
                        {
                            forColumn7 = 0;
                        }
                        if (forColumn7 == 8)
                        {
                            foreach (var item1 in Column7)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column8)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn8 += 1;
                        }
                        else
                        {
                            forColumn8 = 0;
                        }
                        if (forColumn8 == 8)
                        {
                            foreach (var item1 in Column8)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }
                    foreach (var item1 in Row7)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Row8)
            {
                if (item.layer == 6)
                {
                    forrow8 += 1;
                }
                else
                {
                    forrow8 = 0;
                }
                if (forrow8 == 8)
                {
                    foreach (var item3 in Column1)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn1 += 1;
                        }
                        else
                        {
                            forColumn1 = 0;
                        }
                        if (forColumn1 == 8)
                        {
                            foreach (var item1 in Column1)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column2)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn2 += 1;
                        }
                        else
                        {
                            forColumn2 = 0;
                        }
                        if (forColumn2 == 8)
                        {
                            foreach (var item1 in Column2)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column3)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn3 += 1;
                        }
                        else
                        {
                            forColumn3 = 0;
                        }
                        if (forColumn3 == 8)
                        {
                            foreach (var item1 in Column3)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column4)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn4 += 1;
                        }
                        else
                        {
                            forColumn4 = 0;
                        }
                        if (forColumn4 == 8)
                        {
                            foreach (var item1 in Column4)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column5)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn5 += 1;
                        }
                        else
                        {
                            forColumn5 = 0;
                        }
                        if (forColumn5 == 8)
                        {
                            foreach (var item1 in Column5)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column6)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn6 += 1;
                        }
                        else
                        {
                            forColumn6 = 0;
                        }
                        if (forColumn6 == 8)
                        {
                            foreach (var item1 in Column6)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column7)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn7 += 1;
                        }
                        else
                        {
                            forColumn7 = 0;
                        }
                        if (forColumn7 == 8)
                        {
                            foreach (var item1 in Column7)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }

                    foreach (var item3 in Column8)
                    {
                        if (item3.layer == 6)
                        {
                            forColumn8 += 1;
                        }
                        else
                        {
                            forColumn8 = 0;
                        }
                        if (forColumn8 == 8)
                        {
                            foreach (var item1 in Column8)
                            {
                                ToDestroy(item1);
                            }
                        }
                    }
                    foreach (var item1 in Row8)
                    {
                        ToDestroy(item1);
                    }
                }
            }



            foreach (var item in Column1)
            {
                if (item.layer == 6)
                {
                    forColumn1 += 1;
                }
                else
                {
                    forColumn1 = 0;
                }
                if (forColumn1 == 8)
                {
                    foreach (var item1 in Column1)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Column2)
            {
                if (item.layer == 6)
                {
                    forColumn2 += 1;
                }
                else
                {
                    forColumn2 = 0;
                }
                if (forColumn2 == 8)
                {
                    foreach (var item1 in Column2)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Column3)
            {
                if (item.layer == 6)
                {
                    forColumn3 += 1;
                }
                else
                {
                    forColumn3 = 0;
                }
                if (forColumn3 == 8)
                {
                    foreach (var item1 in Column3)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Column4)
            {
                if (item.layer == 6)
                {
                    forColumn4 += 1;
                }
                else
                {
                    forColumn4 = 0;
                }
                if (forColumn4 == 8)
                {
                    foreach (var item1 in Column4)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Column5)
            {
                if (item.layer == 6)
                {
                    forColumn5 += 1;
                }
                else
                {
                    forColumn5 = 0;
                }
                if (forColumn5 == 8)
                {
                    foreach (var item1 in Column5)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Column6)
            {
                if (item.layer == 6)
                {
                    forColumn6 += 1;
                }
                else
                {
                    forColumn6 = 0;
                }
                if (forColumn6 == 8)
                {
                    foreach (var item1 in Column6)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Column7)
            {
                if (item.layer == 6)
                {
                    forColumn7 += 1;
                }
                else
                {
                    forColumn7 = 0;
                }
                if (forColumn7 == 8)
                {
                    foreach (var item1 in Column7)
                    {
                        ToDestroy(item1);
                    }
                }
            }

            foreach (var item in Column8)
            {
                if (item.layer == 6)
                {
                    forColumn8 += 1;
                }
                else
                {
                    forColumn8 = 0;
                }
                if (forColumn8 == 8)
                {
                    foreach (var item1 in Column8)
                    {
                        ToDestroy(item1);
                    }
                }
            }
            scandone = true;
            toScan = false;
        }
        
    }


    void ToDestroy(GameObject DestroyObject)
    {
        if(DestroyObject.transform.childCount > 1)
        {
            Destroy(DestroyObject.transform.GetChild(1).gameObject);
            DestroyObject.gameObject.layer = 3;
            DestroyObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
        }  
        scandone = true;
        toScan = false;
    }
}
