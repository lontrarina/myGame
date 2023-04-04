using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int _tears = 0;
    [SerializeField] private Text _tearsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tear"))
        {
            Destroy(collision.gameObject);
            _tears++;
            _tearsText.text="Bloody tears: "+ _tears;
        }
    }
}
