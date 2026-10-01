/*
{

    [SerializeField]

    private float speed = 2f; // Speed of the NPC movement

    [SerializeField]

    private float tiempoParaCambiar = 2f; // Time interval to change direction

    [SerializeField]

    private Vector3 direction = new Vector3(1, 0, 0); // Initial direction of movement

    [SerializeField]

    private float contadorTiempo = 0f; // Timer to track time elapsed

    [SerializeField]

    private float tiempoTotal = 0f; // Total time elapsed

    [SerializeField]

    private float tiempoMaximo = 10f; // Maximum time for the NPC to move

    [SerializeField]

    private bool isMoving = true; // Flag to control movement

    [SerializeField]

    private bool isPaused = false; // Flag to control pause state

    [SerializeField]

    private bool isStopped = false; // Flag to control stop state

    [SerializeField]

    private bool isReversing = false; // Flag to control reversing direction

    [SerializeField]

    private bool isFinished = false; // Flag to indicate if the NPC has finished moving

    [SerializeField]

    private bool isActive = true; // Flag to control if the NPC is active

    [SerializeField]

    private bool isVisible = true; // Flag to control visibility of the NPC

    [SerializeField]

    private bool isColliding = false; // Flag to indicate if the NPC is colliding with another object

    [SerializeField]

    private bool isGrounded = true; // Flag to indicate if the NPC is grounded

    [SerializeField]

    private bool isJumping = false; // Flag to indicate if the NPC is jumping

    [SerializeField]

    private bool isFalling = false; // Flag to indicate if the NPC is falling

    [SerializeField]

    private bool isAttacking = false; // Flag to indicate if the NPC is attacking

    [SerializeField]

    private bool isDefending = false; // Flag to indicate if the NPC is defending

    [SerializeField]

    private bool isInteracting = false; // Flag to indicate if the NPC is interacting with an object

    [SerializeField]

    private bool isTalking = false; // Flag to indicate if the NPC is talking

    [SerializeField]

    private bool isListening = false; // Flag to indicate if the NPC is listening

    [SerializeField]

    private bool isThinking = false; // Flag to indicate if the NPC is thinking

    float UpdateDirection()

    {

        contadorTiempo += Time.deltaTime;

        if (contadorTiempo >= tiempoParaCambiar)

        {

            contadorTiempo = 0f; // Reset the timer

            speed = -speed; // Reverse the direction of movement   

        }

        return speed;

    }

    void UpdateMovement()

    {

        transform.Translate((direction * speed * Time.deltaTime));

    }

    void OnEnable()

    {

        isActive = true;

    }

    float UpdateTime()

    {

        tiempoTotal += Time.deltaTime;

        if (tiempoTotal >= tiempoMaximo)

        {

            isFinished = true; // Mark the NPC as finished moving

            isActive = false; // Deactivate the NPC

        }

        return tiempoTotal;

    }

    void Update()

    {

        if (isActive && !isPaused && !isStopped && !isFinished)

        {

            UpdateDirection();

            UpdateMovement();

            UpdateTime();

        }

    }

    void PauseMovement()

    {

        isPaused = true;

    }

    void ResumeMovement()

    {

        isPaused = false;

    }

    void StopMovement()

    {

        isStopped = true;

    }

    void ResumeStoppedMovement()

    {

        isStopped = false;

    }

    void ReverseDirection()

    {

        isReversing = true;

        speed = -speed; // Reverse the direction of movement

    }

    void ResumeReversing()

    {

        isReversing = false;

    }


    private void OnCollisionEnter(Collision collision)

{

    isColliding = true;

}

private void OnCollisionExit(Collision collision)

{

    isColliding = false;

}

private void OnTriggerEnter(Collider other)

{

    isInteracting = true;

}

private void OnTriggerExit(Collider other)

{

    isInteracting = false;

}

private void OnBecameVisible()

{

    isVisible = true;

}

private void OnBecameInvisible()

{

    isVisible = false;

}

private void OnGrounded()

{

    isGrounded = true;

}

private void OnJump()

{

    isJumping = true;

    isGrounded = false;

}

private void OnFall()

{

    isFalling = true;

    isGrounded = false;

}

public void Attack()

{

    isAttacking = true;

}

public void Defend()

{

    isDefending = true;

}

public void Talk()

{

    isTalking = true;

}

public void Listen()

{

    isListening = true;

}

public void Think()

{

    isThinking = true;

}

public void StopThinking()

{

    isThinking = false;

}

public void StopTalking()

{

    isTalking = false;

}

public void StopListening()

{

    isListening = false;

}

void OnDisable()

{

    isActive = false;

}

void OnDestroy()

{

    isActive = false;

}

void OnApplicationQuit()

{

    isActive = false;

}

public void ResetNPC()// Resets the NPC's state to its initial values

{

    contadorTiempo = 0f;

    tiempoTotal = 0f;

    isFinished = false;

    isActive = true;

    isPaused = false;

    isStopped = false;

    isReversing = false;

    isVisible = true;

    isColliding = false;

    isGrounded = true;

    isJumping = false;

    isFalling = false;

    isAttacking = false;

    isDefending = false;

    isInteracting = false;

    isTalking = false;

    isListening = false;

    isThinking = false;

}

public void SetSpeed(float newSpeed)// Sets the speed of the NPC's movement

{

    speed = newSpeed;

}

public void SetDirection(Vector3 newDirection)// Sets the direction of the NPC's movement

{

    direction = newDirection.normalized; // Ensure the direction is normalized

}

public void SetTiempoParaCambiar(float newTiempoParaCambiar)// Sets the time interval for changing direction

{

    tiempoParaCambiar = newTiempoParaCambiar;

}

void SetTiempoMaximo(float newTiempoMaximo)// Sets the maximum time for the NPC to move

{

    tiempoMaximo = newTiempoMaximo;

}

void SetIsActive(bool newIsActive)// Sets the active state of the NPC

{

    isActive = newIsActive;

}

float GetSpeed()// Gets the speed of the NPC's movement

{

    return speed;

}

float GetTiempoParaCambiar()// Gets the time interval for changing direction

{

    return tiempoParaCambiar;

}

Vector3 GetDirection()// Gets the direction of the NPC's movement

{

    return direction;

}

public float GetTiempoMaximo()//    Gets the maximum time for the NPC to move

{

    return tiempoMaximo;

}

public bool GetIsActive()// Gets the active state of the NPC

{

    return isActive;

}

float GetTiempoTotal()// Gets the total time elapsed for the NPC's movement

{

    return tiempoTotal;

}

float GetContadorTiempo()// Gets the current value of the timer for changing direction

{

    return contadorTiempo;

}

float GetTiempoRestante()// Gets the remaining time for the NPC to move before reaching the maximum time

{

    return tiempoMaximo - tiempoTotal;

}

float GetContadorTotal()// Gets the total time elapsed including the current timer value

{

    return contadorTiempo + tiempoTotal;

}

float GetTiempoRestanteParaCambiar()// Gets the remaining time before the NPC changes direction

{

    return tiempoParaCambiar - contadorTiempo;

}

float GetTiempoRestanteTotal()// Gets the remaining time for the NPC to move before reaching the maximum time, including the current timer value

{

    return tiempoMaximo - (contadorTiempo + tiempoTotal);

}

float GetTiempoRestanteParaCambiarTotal()// Gets the remaining time before the NPC changes direction, including the current timer value

{

    return tiempoParaCambiar - (contadorTiempo + tiempoTotal);

}

private void OnDrawGizmos()// Draws gizmos in the scene view for debugging purposes

{

    Gizmos.color = Color.red;

    Gizmos.DrawLine(transform.position, transform.position + direction * 2f);

}

public void SetIsPaused(bool newIsPaused)// Sets the paused state of the NPC

{

    isPaused = newIsPaused;

}

public bool IsPaused()// Gets the paused state of the NPC

{

    return isPaused;

}

float GetTiempoRestanteParaCambiarNormalized()

{

    return (tiempoParaCambiar - contadorTiempo) / tiempoParaCambiar;

}

public bool IsFinished()

{

    return isFinished;

}

private void OnValidate()

{

    if (speed < 0f)

    {

        speed = 0f; // Ensure speed is non-negative

    }

    if (tiempoParaCambiar < 0f)

    {

        tiempoParaCambiar = 0f; // Ensure tiempoParaCambiar is non-negative

    }

    if (tiempoMaximo < 0f)

    {

        tiempoMaximo = 0f; // Ensure tiempoMaximo is non-negative

    }

}

float speedNormalized()

{

    return speed / 10f; // Assuming 10 is the maximum speed for normalization

}

float tiempoParaCambiarNormalized()

{

    return tiempoParaCambiar / 10f; // Assuming 10 is the maximum tiempoParaCambiar for normalization

}

float tiempoMaximoNormalized()

{

    return tiempoMaximo / 10f; // Assuming 10 is the maximum tiempoMaximo for normalization

}

float tiempoTotalNormalized()

{

    return tiempoTotal / tiempoMaximo; // Normalize based on tiempoMaximo

}

float contadorTiempoNormalized()

{

    return contadorTiempo / tiempoParaCambiar; // Normalize based on tiempoParaCambiar

}

float tiempoRestanteNormalized()

{

    return (tiempoMaximo - tiempoTotal) / tiempoMaximo; // Normalize based on tiempoMaximo

}

float tiempoTotalRestanteNormalized()

{

    return (tiempoMaximo - (contadorTiempo + tiempoTotal)) / tiempoMaximo; // Normalize based on tiempoMaximo

}

float tiempoRestanteTotalNormalized()

{

    return (tiempoMaximo - (contadorTiempo + tiempoTotal)) / tiempoMaximo; // Normalize based on tiempoMaximo

}

float tiempoRestanteParaCambiarNormalized()

{

    return (tiempoParaCambiar - contadorTiempo) / tiempoParaCambiar; // Normalize based on tiempoParaCambiar

}

private void OnDrawGizmosSelected()

{

    Gizmos.color = Color.green; // Set the color for the gizmo

    Gizmos.DrawLine(transform.position, transform.position + direction * 2f);// Draw a line indicating the direction of movement

}

// Additional methods for controlling the NPC's state can be added here

/// <summary>

/// 

///

/// </summary>

///

private float DrawGizmosNormalized()

{

    return (tiempoParaCambiar - contadorTiempo) / tiempoParaCambiar; // Normalize based on tiempoParaCambiar

}


float drawGizmosNormalized()

{

    return (tiempoParaCambiar - contadorTiempo) / tiempoParaCambiar; // Normalize based on tiempoParaCambiar

}

float drawlineGizmosNormalized()

{

    return (tiempoMaximo - tiempoTotal) / tiempoMaximo; // Normalize based on tiempoMaximo

}

char drawGizmosDirection() // Returns a character representing the direction of movement

{

    if (direction.x > 0)

    {

        return 'R'; // Right

    }

    else if (direction.x < 0)

    {

        return 'L'; // Left

    }

    else if (direction.y > 0)

    {

        return 'U'; // Up

    }

    else if (direction.y < 0)

    {

        return 'D'; // Down

    }

    else

    {

        return 'N'; // None

    }

}

// Additional methods for controlling the NPC's state can be added here

private void Awake()

{

    // Initialization code here

}

void Start()

{

    // Initialization code here

}

void FixedUpdate()

{

    // Physics update code here

}

void LateUpdate()

{

    // Post-update code here

}

private void OnApplicationPause(bool pauseStatus)// Called when the application is paused or resumed

{

    isPaused = pauseStatus;

}

private float GetSpeedNormalized()// Gets the normalized speed of the NPC's movement

{

    return speed / 10f; // Assuming 10 is the maximum speed for normalization

}

private float GetTiempoParaCambiarNormalized()// Gets the normalized time interval for changing direction

{

    return tiempoParaCambiar / 10f; // Assuming 10 is the maximum tiempoParaCambiar for normalization

}
 
}
*/
 