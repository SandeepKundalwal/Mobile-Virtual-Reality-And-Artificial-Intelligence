<h1><img src="https://github.com/SandeepKundalwal/SandeepKundalwal/blob/8d446e2c9043a2b32c254f10165c7b0efce55030/assets/images/unity.svg" width="28px"> &nbsp;Unity 3D</h1>

<h3>RollerBall With No Negative Reward</h3>
<ul>1. Make the RollerBall environment as shown in the lecture consisting of a blue floor, green sphere, and a yellow cube.</ul>
<ul>2. Now, program the sphere to be able to move with heuristic keyboard arrow controls of left – right and forward – back on the floor</ul>
<ul>3. Now, add suitable observations for the sphere position, cube (target) position, and velocity of the sphere on the floor. Furthermore, add suitable reward that is delivered when the sphere is able to touch the cube (target). Also, set the actions for the sphere such that it can be controlled by Unity ML agents library.</ul>
<ul>4. Now, please use the parameter settings in the .yaml file here:</ul>
  <pre>
    <!--code Tag starts here -->
    <code>
      behaviors:
        RollerBall:
          trainer_type: ppo
          hyperparameters:
            batch_size: 10
            buffer_size: 100
            learning_rate: 3.0e-4
            beta: 5.0e-4
            epsilon: 0.2
            lambd: 0.99
            num_epoch: 3
            learning_rate_schedule: linear
            beta_schedule: constant
            epsilon_schedule: linear
          network_settings:
            normalize: false
            hidden_units: 128
            num_layers: 2
          reward_signals:
            extrinsic:
              gamma: 0.99
              strength: 1.0
          max_steps: 500000
          time_horizon: 64
          summary_freq: 10000
      <!--code Tag starts here -->
      </code>
  </pre>
<ul>5. Please train the sphere agent for 50,000 steps and then stop the training by hitting the CTRL + C. Please plot the cumulative reward for this run in TensorBoard.</ul>

<h3>RollerBall With Negative Reward</h3>
<ul>
    1. Please take the agent in Q1 above and make the following changes:
    <ul>
      <li>Set a -1 reward when the sphere falls out of the floor.</li>
      <li>Remove the sphere velocity from observations.</li>
      <li>Make the hidden_units: 64 and num_layers: 1.</li>
    </ul>
</ul>
<pre>
    <!--code Tag starts here -->
    <code>
      behaviors:
        RollerBall:
          trainer_type: ppo
          hyperparameters:
            batch_size: 10
            buffer_size: 100
            learning_rate: 3.0e-4
            beta: 5.0e-4
            epsilon: 0.2
            lambd: 0.99
            num_epoch: 3
            learning_rate_schedule: linear
            beta_schedule: constant
            epsilon_schedule: linear
          network_settings:
            normalize: false
            hidden_units: 64
            num_layers: 1
          reward_signals:
            extrinsic:
              gamma: 0.99
              strength: 1.0
          max_steps: 500000
          time_horizon: 64
          summary_freq: 10000
      <!--code Tag starts here -->
      </code>
  </pre>
<ul>2. Now, please train the agent from scratch for 50,000 steps and plot the cumulative rewards in TensorBoard with respect to the cumulative reward in Question 1. What do you infer about the sphere’s training in Question 2 with respect to the sphere’s training in Question 1?</ul>

<h3>DEMO</h3>

https://github.com/SandeepKundalwal/Mobile-Virtual-Reality-And-Artificial-Intelligence/assets/61798659/d0f548df-dc7b-412d-a4c0-1753bf819d13
