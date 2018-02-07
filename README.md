A recreation of classic block breaking games like Arkanoid. A bat at the bottom of the screen is used to bounce a ball of blocks above. These blocks disappear after one or more hits, and there will be three block types of different colour.    There will be background music, and sound effects for the ball bouncing, and for the blocks breaking. 
This game have three levels. In every level there are bricks which have to be broken by ball which bounces of a paddle. Paddle is controlled by mouse movement. You have to break all the bricks in that level to going in next level. If you fail to hit the ball with paddle and ball falls out, game is over and you have to start again.
This game uses 6 code to control block breaker game. Each code performing specific tasks.
LevelManager – This code is to manage the levels of the game, going from start to level 1 and so the end scene
MusicPlayer script – Responsible for running background music to the game.
Ball Script – Making ball collide with the objects in the game play like bricks, paddle, walls
                      And make it bounce consistently through out the game.
Brick script – applying proper physics to the ball and bricks so they can collide and break when hit by
                        ball
Paddle script – Paddle which moves along x coordinates through mouse detection and where ball 
                             Drops and bounces back
LoseCollider – walls in the game where ball bounces off.
