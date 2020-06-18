using UnityEngine;

public class g08_PyramidSwitch : MonoBehaviour
{
    public Material onMaterial;
    public Material offMaterial;
    public GameObject myButton;
    bool m_State;
    GameObject m_Area;
    g08_PyramidArea m_AreaComponent;
    int m_PyramidIndex;

    public bool GetState()
    {
        return m_State;
    }

    void Start()
    {
        m_Area = gameObject.transform.parent.gameObject;
        m_AreaComponent = m_Area.GetComponent<g08_PyramidArea>();
    }

    public void ResetSwitch(int spawnAreaIndex, int pyramidSpawnIndex)
    {
        m_AreaComponent.PlaceObject(gameObject, spawnAreaIndex);
        m_State = false;
        m_PyramidIndex = pyramidSpawnIndex;
        tag = "switchOff";
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        myButton.GetComponent<Renderer>().material = offMaterial;
    }

    public void changeTag()
    {
        tag = "goal";
        myButton.GetComponent<Renderer>().material = onMaterial;
    }

    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.CompareTag("agent") && m_State == false)
    //    {
    //        myButton.GetComponent<Renderer>().material = onMaterial;
    //        m_State = true;
    //        tag = "switchOn";
    //    }
    //}
}