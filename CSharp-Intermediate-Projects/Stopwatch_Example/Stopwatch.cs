using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Example
{
    public class Stopwatch
    {
        private DateTime _startTime; 
        private DateTime _endTime; 
        private bool _flag; 
        
        public void Start() { 
            if (_flag) 
                throw new InvalidOperationException("Stopwatch is already running."); 
            
            _startTime = DateTime.Now; 
            _flag = true;
        }
        public TimeSpan Stop() {
            if (!_flag) 
                throw new InvalidOperationException("Stopwatch is not running."); 
            
            _endTime = DateTime.Now; 
            _flag = false; 
            
            return _endTime - _startTime; 
        }
    }
}
