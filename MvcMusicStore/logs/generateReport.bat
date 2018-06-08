SET summaryLogFile=%1
.\LogParser.exe -i "TEXTLINE" file:TotalReportScript.sql?file=%summaryLogFile% -o "CSV" -filemode 1 -headers ON
.\LogParser.exe -i "TEXTLINE" file:errorsReportScript.sql?file=%summaryLogFile% -o "CSV" -filemode 0 -headers ON