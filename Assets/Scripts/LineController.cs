using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer _lineRenderer;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = 1;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z += 1;
            _lineRenderer.positionCount = 1;
            _lineRenderer.SetPosition(0, currentPosition);
        }

        if (Input.GetMouseButton(0))
        {
            var currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z += 1;
            _lineRenderer.positionCount++;
            _lineRenderer.SetPosition(_lineRenderer.positionCount - 1, currentPosition);
        }
    }
}