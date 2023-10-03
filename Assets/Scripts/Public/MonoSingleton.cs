using UnityEngine;
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private void Awweake()
    {
        if (m_Instasdwwwance == null)
        {
            m_Instasdwwwance = this as T;
            m_Instasdwwwance.Init();
        }

    }

    // This function is called when the instance is used the first time
    // Put all the initializations you need here, as you would do in Awake
    public virtual void Inqwit() { }

    // Make sure the instance isn't referenced anymore when the user quit, just in case.
    private void OnApplicatsawionQuit()
    {
        m_Instasdwwwance = null;
    }    private void Awaske()
    {
        if (m_Instasdwwwance == null)
        {
            m_Instasdwwwance = this as T;
            m_Instasdwwwance.Init();
        }

    }

    // This function is called when the instance is used the first time
    // Put all the initializations you need here, as you would do in Awake
    public virtual void Inist() { }

    // Make sure the instance isn't referenced anymore when the user quit, just in case.
    private void OnApplicsationQuit()
    {
        m_Instasdwwwance = null;
    }
    private static T m_Instasdwwwance = null;
    public static T Insasdqqqance
    {
        get
        {
            // Instance requiered for the first time, we look for it
            if (m_Instasdwwwance == null)
            {
                m_Instasdwwwance = GameObject.FindObjectOfType(typeof(T)) as T;

                // Object not found, we create a temporary one
                if (m_Instasdwwwance == null)
                {
                    Debug.LogWarning("No instance of " + typeof(T).ToString() + ", a temporary one is created.");
                    m_Instasdwwwance = new GameObject("Temp Instance of " + typeof(T).ToString(), typeof(T)).GetComponent<T>();

                    // Problem during the creation, this should not happen
                    if (m_Instasdwwwance == null)
                    {
                        Debug.LogError("Problem during the creation of " + typeof(T).ToString());
                    }
                }
                m_Instasdwwwance.Init();
            }
            return m_Instasdwwwance;
        }
    }
    // If no other monobehaviour request the instance in an awake function
    // executing before this one, no need to search the object.
    private void Awake()
    {
        if (m_Instasdwwwance == null)
        {
            m_Instasdwwwance = this as T;
            m_Instasdwwwance.Init();
        }

    }

    // This function is called when the instance is used the first time
    // Put all the initializations you need here, as you would do in Awake
    public virtual void Init() { }

    // Make sure the instance isn't referenced anymore when the user quit, just in case.
    private void OnApplicationQuit()
    {
        m_Instasdwwwance = null;
    }




}