<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:order="http://www.rent.movies.com/xml/order">
<xsl:template match="order:objednavka">
	<html> 
		<body style="display:flex; flex-direction:column; width:20%;  margin-top: 3%; margin-left: 40%;">
		  <h2 style="margin:0 auto;">Objednávka filmov</h2>
		  <h4 style="margin:20 auto;">Meno: <xsl:value-of select="order:zakaznik/order:meno"/>, Priezvisko: <xsl:value-of select="order:zakaznik/order:priezvisko"/></h4>
		  <table border="1">
			<tr bgcolor="#8abeff">	
			  <td style="text-align:left">Názov filmu</td>
			  <td style="text-align:left">Počet dní</td>
			</tr>
			<xsl:apply-templates select="order:filmy"/>
		  </table>
		  <h3>Dátum objednávky:</h3>
		  <h4 style="margin:0 auto;"><xsl:value-of select="order:datum"/></h4>
		  <xsl:choose>
			<xsl:when test="order:zakaznik/order:ma_kupon='true'">
				<h5>Zákazník má kupón: <xsl:value-of select="order:zakaznik/@cislo_kuponu" /></h5>
			</xsl:when>
		  </xsl:choose> 
		</body>
	</html>
</xsl:template>
<xsl:template match="order:filmy/order:film">
  <TR bgcolor="#eee">
    <TD><xsl:value-of select="order:nazov"/></TD>
    <TD><xsl:value-of select="order:dlzka_vypozicania"/></TD>
  </TR>
</xsl:template>
</xsl:stylesheet>