<h1><img src="https://github.com/SandeepKundalwal/SandeepKundalwal/blob/8d446e2c9043a2b32c254f10165c7b0efce55030/assets/images/unity.svg" width="28px"> &nbsp;Unity 3D</h1>

<h3>RollerBall + Behavioral Cloning</h3>
<ul>1. Please use the RollerBall environment from Q1 of Assignment 3.</ul>
<ul>2. Now, add the demonstration recorder, and play the game for some number of episodes (please play it long enough for the Unity ML agents to be able to learn from it).</ul>
<ul>3. Now, add behavioural cloning (BC) with a strength of 0.9 and decrease the strength of extrinsic rewards to 0.5. Train the agent for 30,000 steps. Stop the training by hitting CTRL + C and make the BC strength 0.5 and the strength of the
extrinsic reward 1.0. Now, resume the training of the roller agent for another 30,000 steps (you may resume the training by --resume argument in magnets-learn command. Please plot the cumulative reward for this run in TensorBoard.</ul>
  <pre>
    <!--code Tag starts here -->
    <code>
      behaviors:
        RollerBallBC:
          trainer_type: ppo
          hyperparameters:
            batch_size: 64      # Increase batch size for stability
            buffer_size: 4096   # Increase buffer size for better experience replay
            learning_rate: 3.0e-4
            beta: 5.0e-4
            epsilon: 0.2
            lambd: 0.95         # reduced bias in value function
            num_epoch: 5        # more epochs for more stable updates
            learning_rate_schedule: linear
            beta_schedule: constant
            epsilon_schedule: linear
          network_settings:
            normalize: true
            hidden_units: 256
            num_layers: 3
          reward_signals:
            extrinsic:
              gamma: 0.99
              strength: 1.0
          behavioral_cloning:
            strength: 0.5
            steps: 100000
            demo_path: C:/Users/DELL/Desktop/RollerBallBC/Assets/Demonstrations/AgentDemo.demo
          max_steps: 1000000
          time_horizon: 64
          summary_freq: 10000
      <!--code Tag starts here -->
      </code>
  </pre>

<h3>RollerBall + Behavioral Cloning + GAIL + Curiosity</h3>
<ul>Now, add BC with a strength of 0.9, GAIL with a strength of 0.9, and Curiosity with a strength of 0.9 (gamma 0.99), and decrease the strength of extrinsic rewards to 0.5. Train the agent for 30,000 steps. Stop the training by hitting
CTRL + C and make the BC, GAIL, and Curiosity strength 0.5, respectively, and the strength of the extrinsic reward 1.0. Now, resume the training of the roller agent for another 30,000 steps (you may resume the training by --resume argument in ml agents-learn command. Please plot the cumulative reward for this run in TensorBoard. </ul>
<pre>
    <!--code Tag starts here -->
    <code>
     behaviors:
      RollerBallBCGAILCuriosity:
        trainer_type: ppo
        hyperparameters:
          batch_size: 128   # Increased batch size for stability
          buffer_size: 8192  # Increased buffer size for better experience replay
          learning_rate: 3.0e-4 
          beta: 5.0e-4  # Adjusted beta
          epsilon: 0.2
          lambd: 0.95   # Adjusted lambda
          num_epoch: 5  # Increased number of epochs
          learning_rate_schedule: linear
          beta_schedule: constant
          epsilon_schedule: linear
        network_settings:
          normalize: true  # Consider enabling normalization for better convergence
          hidden_units: 256  # Increased hidden units for more capacity
          num_layers: 3  # Experiment with a deeper network for complex tasks
        reward_signals:
          extrinsic:
            gamma: 0.99
            strength: 1.0
          curiosity:
            strength: 0.5
            gamma: 0.99
            network_settings:
              hidden_units: 128
          gail:
            strength: 0.5
            gamma: 0.99
            demo_path: C:/Users/DELL/Desktop/RollerBallBCGAILCuriosity/Assets/Demonstrations/AgentDemo.demo
        behavioral_cloning:
          strength: 0.5
          steps: 100000
          demo_path: C:/Users/DELL/Desktop/RollerBallBCGAILCuriosity/Assets/Demonstrations/AgentDemo.demo
        max_steps: 130000  # Increased max steps
        time_horizon: 64
        summary_freq: 10000
      <!--code Tag starts here -->
      </code>
  </pre>
<ul>2. Please compare the results obtained after 60,000 in Q2 with those in Q1 by using the cumulative reward plot in TensorBoard. </ul>

<h3>Report</h3>
<!-- [Group-18_ Assignment-4.pdf](https://github.com/SandeepKundalwal/Mobile-Virtual-Reality-And-Artificial-Intelligence/files/13194710/Group-18_.Assignment-4.pdf) -->

<object data="https://github.com/SandeepKundalwal/Mobile-Virtual-Reality-And-Artificial-Intelligence/files/13194710/Group-18_.Assignment-4.pdf" type="application/pdf" width="700px" height="700px">
    <embed src="https://github.com/SandeepKundalwal/Mobile-Virtual-Reality-And-Artificial-Intelligence/files/13194710/Group-18_.Assignment-4.pdf">
        <p>This browser does not support PDFs. Please download the PDF to view it: <a href="https://github.com/SandeepKundalwal/Mobile-Virtual-Reality-And-Artificial-Intelligence/files/13194710/Group-18_.Assignment-4.pdf">Download PDF</a>.</p>
    </embed>
</object>

