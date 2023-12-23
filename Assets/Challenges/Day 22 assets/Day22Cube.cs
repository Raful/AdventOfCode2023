using Codice.Client.BaseCommands;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day22Cube : MonoBehaviour
{
    public event Action<Day22Cube> OnCubeStabilized;

    public List<Day22Cube> supportedCubes = new List<Day22Cube>();

    public void FallAsync()
    {
        StartCoroutine(WaitForStart());
    }

    IEnumerator WaitForStart()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        float waitedTime = 0;


        while (waitedTime < transform.position.y / 10f)
        {
            waitedTime += Time.deltaTime;
            yield return null;
        }

        GetComponent<Rigidbody>().constraints -= RigidbodyConstraints.FreezePositionY;

        StartCoroutine(TryStabilize());
    }

    IEnumerator TryStabilize()
    {
        bool hasStabilized = false;

        float lastY = float.MinValue;
        float lastPositionCheck = 0;

        transform.localScale *= 0.95f;

        while (!hasStabilized)
        {
            if (lastPositionCheck >= 3f)
            {
                lastPositionCheck = 0;

                if (Mathf.Abs(lastY - transform.position.y) < 0.2f)
                {
                    transform.position = new Vector3(transform.position.x, Mathf.Round(transform.position.y * 2f) / 2f, transform.position.z);
                    GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                    transform.localScale /= 0.95f;
                    hasStabilized = true;

                    OnCubeStabilized?.Invoke(this);
                }

                lastY = transform.position.y;
            }
            else
            {
                lastPositionCheck += Time.deltaTime;
            }

            if (GetComponent<Rigidbody>().velocity.sqrMagnitude > 0.3f)
                GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * 0.3f;

            yield return null;
        }
    }
}
