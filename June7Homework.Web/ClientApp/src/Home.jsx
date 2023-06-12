import axios from "axios";
import { useState, useEffect } from "react";
import MonthRow from "./MonthRow";

const Home = () => {
    const [schedule, setSchedule] = useState([])

    useEffect(() => {
        const getSchedule = async () => {
            const {data} = await axios.get('/api/LIT/getschedule') 
            setSchedule(data)
        }
        getSchedule()
    },[])

    return(<><div className="container mt-5 col-md-offset-3 col-md-6">
    <table style={{ fontSize: 20 }} className="table table-bordered">
      <tbody>
        {schedule.map(s => <MonthRow
        key={s.monthTitle}
        month={s}/>)}
      </tbody>
    </table>
  </div></>)
}

export default Home

