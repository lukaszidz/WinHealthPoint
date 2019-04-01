import React, { Component } from 'react';
import {
  AreaChart, Area, XAxis, YAxis, CartesianGrid, Tooltip,
} from 'recharts';

const data = [
    {
       cpu: 10,
    },
    {
       cpu: 20,
    },
    {
       cpu: 30, 
    },
    {
       cpu: 10,
    },
    {
       cpu: 40,
    },
    {
       cpu: 40,
    },
    {
       cpu: 0,
    }
  ];
  

class Chart extends Component {
  render() {
    return (
        <AreaChart
          width={500}
          height={400}
          data={data}
          margin={{
            top: 10, right: 30, left: 0, bottom: 0,
          }}
        >
          <CartesianGrid strokeDasharray="3 3" />
          <XAxis dataKey="name" domain={[0, 20]} />
          <YAxis type="number" domain={[0, 100]} />
          <Tooltip />
          <Area type="monotone" dataKey="cpu" stroke="#8884d8" fill="#8884d8" />
        </AreaChart>
    );
  }
}

export default Chart;