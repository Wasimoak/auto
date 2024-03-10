Imports System.Collections.Generic

Module EmailTemplates


    Dim Subject1 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->
   
</head>
<body>

    <div>

        <p>Subject : Security-Based Swap Dealer Deminimis Extract Request | {{DATE_RANGE}} - K2</p>

        <p>Hi team:</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation of Security Based Swaps.</p>

        <p>Attached you will find documentation previously provided with specifications on the data request.</p>

        <p>Please let us know if you have any questions.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>

"
    Dim Subject2 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->
</head>
<body>

    <div>

        <p>Subject : Security-Based Swap Dealer Deminimis Extract Request | {{DATE_RANGE}} - SwapOne</p>

        <p>Hello Christopher/Gladson:</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation of Security Based Swaps.</p>

        <p>Attached you will find documentation previously provided with specifications on the data request.</p>

        <p>Please let us know if you have any questions.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>
"
    Dim Subject3 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->

    <style>
        table {{
            border-collapse: collapse;
            width: 100%;
        }}
        th, td {{
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }}
        th {{
            font-weight: bold;
            background-color: #cc8db6;
        }}
        .highlight {{
            background-color: yellow;
        }}
    </style>
    
</head>
<body>

    <div>

        <p>Subject : SCOTS - Dodd-Frank DeMinimis Extract Request | {{DATE_RANGE}}</p>

        <p>Hi Amit:</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation for the following entity identified below. Please note update highlighted below:</p>

        <table>
            <tr>
                <th>Source System</th>
                <th>Derivatives</th>
                <th>Country</th>
                <th>Entity</th>
                <th>Legal Entity Identifier</th>
            </tr>
            <tr>
                <td>SCOTS</td>
                <td>Y</td>
                <td>Canada</td>
                <td>Scotia Commodities Inc.</td>
                <td>549300NQB50X0B1HJE68</td>
            </tr>
        </table>

        <p>If there are any changes to the list of in scope entities noted above, please confirm.</p>

        <p><b>As a reminder, please be guided by the requirements for the De Minimis Calculation and note the following should be included in your data set:</b>
            <ul>
                <li>Transactions with a Trade Date which falls within the period but have matured should still be included in your data set</li>
                <li>Counterparties with an Overall Compliance Status of ""Yes"" or ""Pending""</li>
                <li><span class=""highlight"">Counterparties with a US Person Type with any of the following:</span>
                    <ul>
                        <li><span class=""highlight"">US legal entity</span></li>
                        <li><span class=""highlight"">Foreign company guaranteed by a US legal entity and/or</span></li>
                        <li><span class=""highlight"">Affiliate conduit of a US person</span></li>
                    </ul>
                    
                </li>
            </ul>
        </p>

        <p>Please submit the required data by <b><u>end of day {{MONTH}} 4.</u></b></p>

        <p>If you have any questions, please do not hesitate to ask.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>
"
    Dim Subject4 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->

    <style>
        table {{
            border-collapse: collapse;
            width: 100%;
        }}
        th, td {{
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }}
        th {{
            font-weight: bold;
            background-color: #cc8db6;
        }}
        .highlight {{
            background-color: yellow;
        }}
    </style>
    
</head>
<body>

    <div>

        <p>Subject : Murex - Dodd-Frank DeMinimis Extract Request | {{DATE_RANGE}}</p>

        <p>Hello Teams:</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation for the following entity/source identified below. Please note update highlighted below:</p>

        <table>
            <tr>
                <th>Source System</th>
                <th>Derivatives</th>
                <th>Country</th>
                <th>Entity</th>
                <th>Legal Entity Identifier</th>
            </tr>
            <tr>
                <td>Murex</td>
                <td>Y</td>
                <td>United Kingdom</td>
                <td>Scotiabank Europe PLC</td>
                <td>5493001DQYQ5GT8RL036</td>
            </tr>
        </table>

        <p>If there are any changes to the list of in scope entities noted above, please confirm.</p>

        <p><b>As a reminder, please be guided by the requirements for the De Minimis Calculation and note the following should be included in your data set:</b>
            <ul>
                <li>Transactions with a Trade Date which falls within the period but have matured should still be included in your data set</li>
                <li><span class=""highlight"">Counterparties with a US Person Type with any of the following:</span>
                    <ul>
                        <li><span class=""highlight"">US legal entity</span></li>
                        <li><span class=""highlight"">Foreign company guaranteed by a US legal entity and/or</span></li>
                        <li><span class=""highlight"">Affiliate conduit of a US person</span></li>
                    </ul>
                    
                </li>
            </ul>
        </p>

        <p>Please submit the required data by <b><u>end of day {{Month}} 4.</u></b></p>

        <p>If you have any questions, please do not hesitate to ask.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>
"
    Dim Subject5 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->

    <style>
        table {{
            border-collapse: collapse;
            width: 100%;
        }}
        th, td {{
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }}
        th {{
            font-weight: bold;
            background-color: #cc8db6;
        }}
        .highlight {{
            background-color: yellow;
        }}
    </style>
    
</head>
<body>

    <div>

        <p>Subject : Mexico - Dodd-Frank DeMinimis Extract Request | {{DATE_RANGE}}</p>

        <p>Hello Teams:</p>

        <p><span class=""highlight""><b>Please provide an extract of US Persons identified locally with your DeMinimis data set.</b></span> Per the attached training, Teams are responsible for reviewing their counterparty populations to identify any additional counterparties that should be classified as U.S. Persons.</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation for the following entities and source systems identified below. Please note update highlighted below:</p>

        <table>
            <tr>
                <th>Source System</th>
                <th>Derivatives</th>
                <th>Country</th>
                <th>Entity</th>
                <th>Legal Entity Identifier</th>
            </tr>
            <tr>
                <td>ICARUS</td>
                <td>Y</td>
                <td>Mexico</td>
                <td>Scotia Inverlat Casa de Bolsa, S.A. de C.V., Grupo Financiero Scotiabank Inverlat</td>
                <td>5493001DQYQ5GT8RL036</td>
            </tr>
            <tr>
                <td>K2</td>
                <td>Y</td>
                <td>Mexico</td>
                <td>Scotia Inverlat Casa de Bolsa, S.A. de C.V., Grupo Financiero Scotiabank Inverlat</td>
                <td>5493001DQYQ5GT8RL036</td>
            </tr>
            <tr>
                <td>K2</td>
                <td>Y</td>
                <td>Mexico</td>
                <td>Scotiabank Inverlat S.A.</td>
                <td>549300T60BY4RTBQCL56</td>
            </tr>
            <tr>
                <td>OPICS</td>
                <td>Y</td>
                <td>Mexico</td>
                <td>Scotia Inverlat Casa de Bolsa, S.A. de C.V., Grupo Financiero Scotiabank Inverlat</td>
                <td>5493001DQYQ5GT8RL036</td>
            </tr>
            <tr>
                <td>OPICS</td>
                <td>Y</td>
                <td>Mexico</td>
                <td>Scotiabank Inverlat S.A.</td>
                <td>549300T60BY4RTBQCL56</td>
            </tr>
            <tr>
                <td>WSS</td>
                <td>Y</td>
                <td>Mexico</td>
                <td>Scotiabank Inverlat S.A.</td>
                <td>549300T60BY4RTBQCL56</td>
            </tr>
        </table>

        <p>If there are any changes to the list of in scope entities noted above, please confirm.</p>

        <p><b>As a reminder, please be guided by the requirements for the De Minimis Calculation and note the following should be included in your data set:</b>
            <ul>
                <li>Transactions with a Trade Date which falls within the period but have matured should still be included in your data set</li>
                <li>Counterparties with a US Person Type with any of the following:
                    <ul>
                        <li>US legal entity</li>
                        <li>Foreign company guaranteed by a US legal entity and/or</li>
                        <li>Affiliate conduit of a US person</li>
                    </ul>
                    
                </li>
            </ul>
        </p>

        <p>Please submit the required data by <b><u>end of day {{MONTH}} 4.</u></b></p>

        <p>If you have any questions, please do not hesitate to ask.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>
"
    Dim Subject6 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->

    <style>
        table {{
            border-collapse: collapse;
            width: 100%;
        }}
        th, td {{
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }}
        th {{
            font-weight: bold;
            background-color: #cc8db6;
        }}
        .highlight {{
            background-color: yellow;
        }}
    </style>
    
</head>
<body>

    <div>

        <p>Subject : OPICS - Dodd-Frank DeMinimis Extract Request | {{DATE_RANGE}}</p>

        <p>Hi Paul:</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation for the following entity/source system identified below. Please note update highlighted below:</p>

        <table>
            <tr>
                <th>Source System</th>
                <th>Derivatives</th>
                <th>Country</th>
                <th>Entity</th>
                <th>Legal Entity Identifier</th>
            </tr>
            <tr>
                <td>OPICS</td>
                <td>Y</td>
                <td>Jamaica</td>
                <td>Scotia Investments Jamaica Limited</td>
                <td>549300JK865OUJRKJV94</td>
            </tr>
        </table>

        <p>If there are any changes to the list of in scope entities noted above, please confirm.</p>

        <p><b>As a reminder, please be guided by the requirements for the De Minimis Calculation and note the following should be included in your data set:</b>
            <ul>
                <li>Transactions with a Trade Date which falls within the period but have matured should still be included in your data set</li>
                <li><span class=""highlight"">Counterparties with a US Person Type with any of the following:</span>
                    <ul>
                        <li><span class=""highlight"">US legal entity</span></li>
                        <li><span class=""highlight"">Foreign company guaranteed by a US legal entity and/or</span></li>
                        <li><span class=""highlight"">Affiliate conduit of a US person</span></li>
                    </ul>
                </li>
            </ul>
        </p>

        <p>Please submit the required data by <b><u>end of day {{MONTH}} 4.</u></b></p>

        <p>If you have any questions, please do not hesitate to ask.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>
"
    Dim Subject7 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->

    <style>
        table {{
            border-collapse: collapse;
            width: 100%;
        }}
        th, td {{
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }}
        th {{
            font-weight: bold;
            background-color: #cc8db6;
        }}
        .highlight {{
            background-color: yellow;
        }}
    </style>
    
</head>
<body>

    <div>

        <p>Subject : Peru - Dodd-Frank DeMinimis Extract Request | {{DATE_RANGE}}</p>

        <p>Hello Team:</p>

        <p><span class=""highlight""><b>Please provide an extract of US Persons identified locally with your DeMinimis data set.</b></span> Per the attached training, Teams are responsible for reviewing their counterparty populations to identify any additional counterparties that should be classified as U.S. Persons.</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation for the following entities and source systems identified below. Please note update highlighted below:</p>

        <p>Also attached is the updated list of in scope counterparties to support your calculation.</p>

        <table>
            <tr>
                <th>Source System</th>
                <th>Derivatives</th>
                <th>Country</th>
                <th>Entity</th>
                <th>Legal Entity Identifier</th>
            </tr>
            <tr>
                <td>K2</td>
                <td>Y</td>
                <td>Peru</td>
                <td>Scotiabank Peru SAA</td>
                <td>5493001E54CPRG5J5Q41</td>
            </tr>
            <tr>
                <td>Trader Live</td>
                <td>Y</td>
                <td>Peru</td>
                <td>Scotiabank Peru</td>
                <td>5493001E54CPRG5J5Q41</td>
            </tr>
        </table>

        <p>If there are any changes to the list of in scope entities noted above, please confirm.</p>

        <p><b>As a reminder, please be guided by the requirements for the De Minimis Calculation and note the following should be included in your data set:</b>
            <ul>
                <li>Transactions with a Trade Date which falls within the period but have matured should still be included in your data set</li>
                <li>Counterparties with a US Person Type with any of the following:
                    <ul>
                        <li>US legal entity</li>
                        <li>Foreign company guaranteed by a US legal entity and/or</li>
                        <li>Affiliate conduit of a US person</li>
                    </ul>
                    
                </li>
            </ul>
        </p>

        <p>Please submit the required data by <b><u>end of day {{MONTH}} 4.</u></b></p>

        <p>If you have any questions, please do not hesitate to ask.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>
"
    Dim Subject8 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->

    <style>
        table {{
            border-collapse: collapse;
            width: 100%;
        }}
        th, td {{
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }}
        th {{
            font-weight: bold;
            background-color: #cc8db6;
        }}
        .highlight {{
            background-color: yellow;
        }}
    </style>
    
</head>
<body>

    <div>

        <p>Subject : Colombia - Dodd-Frank DeMinimis Extract Request | {{DATE_RANGE}}</p>

        <p>Hello Team:</p>

        <p><span class=""highlight""><b>Please provide an extract of US Persons identified locally with your DeMinimis data set.</b></span> Per the attached training, Teams are responsible for reviewing their counterparty populations to identify any additional counterparties that should be classified as U.S. Persons.</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation for the following entities and source systems identified below. Please note update highlighted below:</p>

        <p>Also attached is the updated list of in scope counterparties to support your calculation.</p>

        <table>
            <tr>
                <th>Source System</th>
                <th>Derivatives</th>
                <th>Country</th>
                <th>Entity</th>
                <th>Legal Entity Identifier</th>
            </tr>
            <tr>
                <td>Kondor/Kondor +</td>
                <td>Y</td>
                <td>Colombia</td>
                <td>Scotiabank Colpatria S.A.</td>
                <td>5493003NMRIY0Z3WLF37</td>
            </tr>
        </table>

        <p>If there are any changes to the list of in scope entities noted above, please confirm.</p>

        <p><b>As a reminder, please be guided by the requirements for the De Minimis Calculation and note the following should be included in your data set:</b>
            <ul>
                <li>Transactions with a Trade Date which falls within the period but have matured should still be included in your data set</li>
                <li>Counterparties with a US Person Type with any of the following:
                    <ul>
                        <li>US legal entity</li>
                        <li>Foreign company guaranteed by a US legal entity and/or</li>
                        <li>Affiliate conduit of a US person</li>
                    </ul>
                    
                </li>
            </ul>
        </p>

        <p>Please submit the required data by <b><u>end of day {{MONTH}} 4.</u></b></p>

        <p>If you have any questions, please do not hesitate to ask.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>
"
    Dim Subject9 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->

    <style>
        table {{
            border-collapse: collapse;
            width: 100%;
        }}
        th, td {{
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }}
        th {{
            font-weight: bold;
            background-color: #cc8db6;
        }}
        .highlight {{
            background-color: yellow;
        }}
    </style>
    
</head>
<body>

    <div>

        <p>Subject : Uruguay - Dodd-Frank DeMinimis Extract Request | {{DATE_RANGE}}</p>

        <p>Hello Team:</p>

        <p><span class=""highlight""><b>Please provide an extract of US Persons identified locally with your DeMinimis data set.</b></span> Per the attached training, Teams are responsible for reviewing their counterparty populations to identify any additional counterparties that should be classified as U.S. Persons.</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation for the following entities and source systems identified below. Please note update highlighted below:</p>

        <p>Also attached is the updated list of in scope counterparties to support your calculation.</p>

        <table>
            <tr>
                <th>Source System</th>
                <th>Derivatives</th>
                <th>Country</th>
                <th>Entity</th>
                <th>Legal Entity Identifier</th>
            </tr>
            <tr>
                <td>Dynatech</td>
                <td>Y</td>
                <td>Uruguay</td>
                <td>Scotiabank Uruguay S.A.</td>
                <td>54930020E6CBTX7HHT21</td>
            </tr>
        </table>

        <p>If there are any changes to the list of in scope entities noted above, please confirm.</p>

        <p><b>As a reminder, please be guided by the requirements for the De Minimis Calculation and note the following should be included in your data set:</b>
            <ul>
                <li>Transactions with a Trade Date which falls within the period but have matured should still be included in your data set</li>
                <li>Counterparties with a US Person Type with any of the following:
                    <ul>
                        <li>US legal entity</li>
                        <li>Foreign company guaranteed by a US legal entity and/or</li>
                        <li>Affiliate conduit of a US person</li>
                    </ul>
                    
                </li>
            </ul>
        </p>

        <p>Please submit the required data by <b><u>end of day {{MONTH}} 4.</u></b></p>

        <p>If you have any questions, please do not hesitate to ask.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>
"
    Dim Subject10 As String = $"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Your Title Here</title>
    <!-- Add any additional meta tags, CSS links, or scripts here -->

    <style>
        table {{
            border-collapse: collapse;
            width: 100%;
        }}
        th, td {{
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }}
        th {{
            font-weight: bold;
            background-color: #cc8db6;
        }}
        .highlight {{
            background-color: yellow;
        }}
    </style>
    
</head>
<body>

    <div>

        <p>Subject : Chile - Dodd-Frank DeMinimis Extract Request | {{DATE_RANGE}}</p>

        <p>Hello Team:</p>

        <p><span class=""highlight""><b>Please provide an extract of US Persons identified locally with your DeMinimis data set.</b></span> Per the attached training, Teams are responsible for reviewing their counterparty populations to identify any additional counterparties that should be classified as U.S. Persons.</p>

        <p>Please provide data for the period <b>{{DATE_RANGE}}</b> to support this month's DeMinimis calculation for the following entities and source systems identified below. Please note update highlighted below:</p>

        <p>Also attached is the updated list of in scope counterparties to support your calculation.</p>

        <table>
            <tr>
                <th>Source System</th>
                <th>Derivatives</th>
                <th>Country</th>
                <th>Entity</th>
                <th>Legal Entity Identifier</th>
            </tr>
            <tr>
                <td>Kondor/Kondor +</td>
                <td>Y</td>
                <td>Chile</td>
                <td>Scotiabank Chile S.A. (Scotiabank Azul's legal successor)</td>
                <td>54930018SOOHBHRLWC16</td>
            </tr>
        </table>

        <p>If there are any changes to the list of in scope entities noted above, please confirm.</p>

        <p><b>As a reminder, please be guided by the requirements for the De Minimis Calculation and note the following should be included in your data set:</b>
            <ul>
                <li>Transactions with a Trade Date which falls within the period but have matured should still be included in your data set</li>
                <li>Counterparties with a US Person Type with any of the following:
                    <ul>
                        <li>US legal entity</li>
                        <li>Foreign company guaranteed by a US legal entity and/or</li>
                        <li>Affiliate conduit of a US person</li>
                    </ul>
                    
                </li>
            </ul>
        </p>

        <p>Please submit the required data by <b><u>end of day {{MONTH}} 4.</u></b></p>

        <p>If you have any questions, please do not hesitate to ask.</p>

        <p>Thanks,<br>Haojie</p>

    </div>

</body>
</html>
"


    Function LoadEmailTemplates()
        ' Define a dictionary to hold the email templates
        Dim EmailTemplatesDict As New Dictionary(Of String, String)
        EmailTemplatesDict.Add("Subject1", Subject1)
        EmailTemplatesDict.Add("Subject2", Subject2)
        EmailTemplatesDict.Add("Subject3", Subject3)
        EmailTemplatesDict.Add("Subject4", Subject4)
        EmailTemplatesDict.Add("Subject5", Subject5)
        EmailTemplatesDict.Add("Subject6", Subject6)
        EmailTemplatesDict.Add("Subject7", Subject7)
        EmailTemplatesDict.Add("Subject8", Subject8)
        EmailTemplatesDict.Add("Subject9", Subject9)
        EmailTemplatesDict.Add("Subject10", Subject10)

        Return EmailTemplatesDict
    End Function



End Module
