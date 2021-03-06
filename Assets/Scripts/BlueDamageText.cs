﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDamageText : MonoBehaviour
{

    private TextMesh damageText;
    private PlayerHitPoints2 php;

    private Color textColor;

    // Start is called before the first frame update
    void Start()
    {
        php = GameObject.Find("Body2").GetComponent<PlayerHitPoints2>();
        damageText = GetComponent<TextMesh>();
        textColor = GetComponent<TextMesh>().color;
    }

    // Update is called once per frame
    void Update()
    {
        damageText.text = php.getDamage().ToString();
        transform.position += new Vector3(0, 1 * Time.deltaTime, 0);

        textColor.a -= 0.4f;

        Invoke("destroyText", 1);

    }


    private void destroyText()
    {
        Destroy(gameObject);
    }
}
