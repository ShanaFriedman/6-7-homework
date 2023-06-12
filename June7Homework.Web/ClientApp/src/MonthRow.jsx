
const MonthRow = ({ month }) => {
    return (<>
        <tr>
        <td style={{ verticalAlign: "middle" }}>{month.monthTitle}</td>
          <td>
            <ul>
                {month.topics.map(t => {
                    return(<li key={t}>{t}</li>)
                })}
            </ul>
          </td>
        </tr>
        
    </>)
}

export default MonthRow