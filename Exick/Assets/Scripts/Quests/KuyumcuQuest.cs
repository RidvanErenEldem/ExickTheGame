using UnityEngine;

public class KuyumcuQuest : QuestSetup
{
    private AudioSource source;
    public AudioClip clip;
    public GameObject destroyObj;
    public GameObject questObj;
    public GameObject instObj;
    public Transform instTransform;

    private void Start() 
    {
        source = GetComponent<AudioSource>();
    }

    protected override void Process()
    {
        Instantiate(questObj, instTransform.position, transform.rotation);
        Destroy(destroyObj);
        source.PlayOneShot(clip);
        Instantiate(instObj, instTransform.position, Quaternion.identity);
    }
}
