using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HatVisualiser : MonoBehaviour {

    [SerializeField]
    private List<Hat> hats;

    [SerializeField]
    private Hat currentHat;

    [SerializeField]
    private PlayerData playerData;

    public Hat CurrentHat => currentHat;

    public void Start(){
        if (hats == null){
            throw new NullReferenceException(nameof(hats));
        }

        hats[0].gameObject.SetActive(true);
        hats.Skip(1).ToList().ForEach(hat => hat.gameObject.SetActive(false));
    }

    public void SelectHat(int index){
        if (index < 0 || (index + 1) > hats.Count){
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (hats == null){
            throw new NullReferenceException(nameof(hats));
        }

        currentHat = hats[index];
        playerData.IndexHat = index;
        for (int i = 0; i < hats.Count; i++){
            if (i == index){
                hats[i].gameObject.SetActive(true);
            } else {
                hats[i].gameObject.SetActive(false);
            }
        }
    }

    public IEnumerable<IReadonlyHat> GetHats(){
        if (hats == null){
            throw new NullReferenceException(nameof(hats));
        }

        return hats;
    }
}