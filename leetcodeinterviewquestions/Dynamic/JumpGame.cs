using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeinterviewquestions.Dynamic
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            var canJump = new bool[nums.Length];
            canJump[0] = true;
            for (var i = 0; i < nums.Length; ++i)
            {
                if (!canJump[i])
                    continue;
                for (var j = 1; j <= nums[i]; ++j)
                {
                    if (i + j < nums.Length)
                    {
                        canJump[i + j] = true;
                    }
                }
            }
            return canJump[canJump.Length - 1];
        }
    }
}
