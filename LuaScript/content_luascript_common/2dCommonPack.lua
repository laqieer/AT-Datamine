--[[
	主にエリア系のデモで使用する2D関連に対応した関数を記入する
]]

-- ---------------------------------------------------------------------------------------------------------------------
-- エリア用キャラ設定関数
-- area_setup_101009_Noir(target, pose)
-- 	target	エリア配置時に定義しているID　※主人公（ノワール）は"Player"
-- 	pose	初期ポーズモーション　※省略可能
-- 	返り値	コントローラID
-- ---------------------------------------------------------------------------------------------------------------------

function area_setup_101009_Noir(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101noir", "MotionPack_101Noir", "content_animationpack__common", "FacialPack")
	character2DFull(label, "Noir", 101009002)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101001_Tyrfing(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101tyrf", "MotionPack_101Tyrf", "content_animationpack__common", "FacialPack")
	character2DFull(label, "Tyrfing", 101001001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101010_Lancelot(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101lanc", "MotionPack_101Lanc", "content_animationpack__common", "FacialPack")
	character2DFull(label, "Lancelot", 101010001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101011_Guinevere(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101guin", "MotionPack_101Guin", "content_animationpack__common", "FacialPack")
	character2DFull(label, "Guinevere", 101011001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101012_Dinatan(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101dina", "MotionPack_101Dina", "content_animationpack__common", "FacialPack")
	character2DFull(label, "Dinatan", 101012001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101013_Gawain(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101gawa", "MotionPack_101Gawa", "content_animationpack__common", "FacialPack")
	character2DFull(label, "Gawain", 101013001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101016_Gwenhwymawr(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101gwen", "MotionPack_101Gwen", "content_animationpack__common", "FacialPack")
	character2DFull(label, "Gwenhwymawr", 101016001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101017_Maladisant(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101mala", "MotionPack_101Mala", "content_animationpack__common", "FacialPack")
	character2DFull(label, "Maladisant", 101017001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101018_Ragnar(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101ragn", "MotionPack_101Ragn", "content_animationpack__common", "FacialPack")
	character2DFull(label, "Ragnar", 101018001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101015_Arthur(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101arth", "MotionPack_101Arth", "content_animationpack__common", "FacialPack")
	character2DMinimum(label, "Arthur", 101015001)

	if pose ~= nil then
		debug_print("通った")
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101030_Elaine(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101elai", "MotionPack_101Elai", "content_animationpack__common", "FacialPack")
	character2DMinimum(label, "Elaine", 101030001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101040_Kay(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101kay", "MotionPack_101Kay", "content_animationpack__common", "FacialPack")
	character2DMinimum(label, "Kay", 101040001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101041_Morgan(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101morg", "MotionPack_101Morg", "content_animationpack__common", "FacialPack")
	character2DMinimum(label, "Morgan", 101041001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101062_Maril(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101mari", "MotionPack_101Mari", "content_animationpack__common", "FacialPack")
	character2DMinimum(label, "Maril", 101062001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101063_Christina(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101chri", "MotionPack_101Chri", "content_animationpack__common", "FacialPack")
	character2DMinimum(label, "Christina", 101063001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_101064_Liam(target, pose)

	local label

	label = get_chara(target, "content_animationpack_101_101liam", "MotionPack_101Liam", "content_animationpack__common", "FacialPack")
	character2DMinimum(label, "Liam", 101064001)

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end



function area_setup_MOB01_M(target, pose)

	local label

	label = get_chara(target, "content_animationpack_100_100mobm", "MotionPack_100MobM", "content_animationpack__common", "FacialPack")

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end

function area_setup_MOB01_F(target, pose)

	local label

	label = get_chara(target, "content_animationpack_100_100mobf", "MotionPack_100MobF", "content_animationpack__common", "FacialPack")

	if pose ~= nil then
		motion(label, pose, 0, 1.0, true)
	end

	return(label)
end



-- ---------------------------------------------------------------------------------------------------------------------
-- 以下は旧リソースID対応版のため、移行完了後のタイミングで順次廃止予定
-- ---------------------------------------------------------------------------------------------------------------------

--[[
	キャラクターのデザインリソースの共通設定関数
	コントローラIDは呼び出す共通関数内で固定で設定

	例：setup_Noir(CHARA1_AREA110011) -- コントローラIDは「Noir」
	　　setup2D_Noir(CHARA1_AREA110011) -- バトルADV用。3Dモデル未使用、2D顔イラストのみ使用する

		Noir		ノワール：制服
		Noir2		ノワール：金コート
		Lancelot	ランスロット
	        Guinevere	ギネヴィア
	        Dinatan		ディナタン※3Dモデル以外はダミー

		Arthur		アーサー※
		Kay		ケイ※
		Gawain		ガウェイン※
		Ragnar		ラグネル（ガラティン）※
		Gwenhwymawr	ギネマウア（ロンゴミアント）※
		Maladisant	マルディサント※

		Tyrfing		ティルフィング※
		Morgan		モルガン※

		Moronoe		モーノロエー
		Barbaroi	バルバロイ※

		Noir_mom	ノワール母※

		（未定）	ブルーノ（傭兵）旧ジョワイユ
		（未定）	ノワール（幼少期）
		（未定）	ディナタン（幼少期）

				※マークはリソースが未実装のためダミーモデルを使用
]]

function setup_Noir(pos)
	Noir = set_chara("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Sri_Std_loop_m", "Normal")
	character2DDefaultStyleFull(Noir, "Noir",101009)
end

function setup_Noir2(pos)
	-- 金コート版
	Noir = set_chara("content_chr_101009_101009001_model", "101009001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Sri_Std_loop_m", "Normal")
	character2DFull(Noir, "Noir",101009001)
end

function setup_Lancelot(pos)
	Lancelot = set_chara("content_chr_101010_101010001_model", "101010001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Col_Std_loop_m", "Normal")
	character2DFull(Lancelot, "Lancelot", 101010001)
end

function setup_Guinevere(pos)
	Guinevere = set_chara("content_chr_101011_101011001_model", "101011001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Nbl_Std_loop_f", "Normal")
	character2DFull(Guinevere, "Guinevere", 101011001)
end

function setup_Dinatan(pos)
	Dinatan = set_chara("content_chr_101012_101012001_model", "101012001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Nbl_Std_loop_f", "Normal")
	character2DFull(Dinatan, "Dinatan", 101012001)
end

function setup_Tyrfing(pos)
	Tyrfing = set_chara("content_chr_101001_101001001_model", "101001001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Nbl_Std_loop_f", "Normal")
	character2DFull(Tyrfing, "Tyrfing", 101001001)
end

function setup_Morgan(pos)
	Morgan = set_chara("content_chr_101041_101041001_model", "101041001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
	character2DMinimum(Morgan, "Morgan", 101041001)
end

function setup_Arthur(pos)
	Arthur = set_chara("content_chr_101015_101015001_model", "101015001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	character2DMinimum(Arthur, "Arthur", 101015001)
end

function setup_Kay(pos)
	Kay = set_chara("content_chr_101040_101040001_model", "101040001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	character2DMinimum(Kay, "Kay", 101040001)
end

function setup_Gawain(pos)
	Gawain = set_chara("content_chr_101013_101013001_model", "101013001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	character2DMinimum(Gawain, "Gawain", 101013001)
end

function setup_Ragnar(pos)
	Ragnar = set_chara("content_chr_101018_101018001_model", "101018001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
	character2DMinimum(Ragnar, "Ragnar", 101018001)
end

function setup_Gwenhwymawr(pos)
	Gwenhwymawr = set_chara("content_chr_101016_101016001_model", "101016001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
	character2DMinimum(Gwenhwymawr, "Gwenhwymawr", 101016001)
end

function setup_Maladisant(pos)
	Maladisant = set_chara("content_chr_101017_101017001_model", "101017001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
	character2DMinimum(Maladisant, "Maladisant", 101017001)
end

function setup_Moronoe(pos)
	Moronoe = set_chara("content_chr_101042_101042001_model", "101042001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	character2DMinimum(Moronoe, "Moronoe", 101042001)
end

--[[

	NPC系の共通関数は関数の戻り値をコントローラIDとして利用する

	例：MOB1 = setup_MOB_StudentB(CHARA1_AREA110011)

	        MOB_StudentB	モブ男子生徒
	        MOB_StudentG	モブ女子生徒

		MOB_Soldier	キャメロット兵士/傭兵※
		MOB_CitizenM	モブ男村人（商人）/教師※

				※マークはリソースが未実装のためダミーモデルを使用

]]

function setup_MOB_StudentB(pos)
	local label
	label = set_chara("content_chr_401005_401005001_model", "401005001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	return(label)
end

function setup_MOB_StudentG(pos)
	local label
	label = set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
	return(label)
end

function setup_MOB_Soldier(pos)
	local label
	label = set_chara("content_chr_401036_401036001_model", "401036001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	return(label)
end

function setup_MOB_CitizenM(pos)
	local label
	label = set_chara("content_chr_401011_401011001_model", "401011001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	return(label)
end



function setup2D_Noir()
--制服
	Noir = set_chara_unknown()
	character2DFull(Noir, "Noir", 101009002)

--制服・金コート
	Noir2 = set_chara_unknown()
	character2DFull(Noir2, "Noir2", 101009001)

--傭兵
	Noir3 = set_chara_unknown()
	character2DFull(Noir3, "Noir3", 101009003)
end

function setup2D_Lancelot()
--通常体
	Lancelot = set_chara_unknown()
	character2DFull(Lancelot, "Lancelot", 101010001)

--キラーズ体
	Lancelot2 = set_chara_unknown()
	character2DFull(Lancelot2, "Lancelot2", 101010002)

--イミテーション
	Lancelot3 = set_chara_unknown()
	character2DFull(Lancelot3, "Lancelot3", 101010007)
end

function setup2D_Guinevere()
--通常体
	Guinevere = set_chara_unknown()
	character2DFull(Guinevere, "Guinevere", 101011001)

--キラーズ体
	Guinevere2 = set_chara_unknown()
	character2DFull(Guinevere2, "Guinevere2", 101011002)

--イミテーション
	Guinevere3 = set_chara_unknown()
	character2DFull(Guinevere3, "Guinevere3", 101011007)
end


function setup2D_Dinatan()
--通常体
	Dinatan = set_chara_unknown()
	character2DFull(Dinatan, "Dinatan", 101012001)

--キラーズ体
	Dinatan2 = set_chara_unknown()
	character2DFull(Dinatan2, "Dinatan2", 101012002)

--連合軍
	Dinatan3 = set_chara_unknown()
	character2DFull(Dinatan3, "Dinatan3", 101012003)

--イミテーション
	Dinatan4 = set_chara_unknown()
	character2DFull(Dinatan4, "Dinatan4", 101012008)

end


function setup2D_Tyrfing()
--通常体
	Tyrfing = set_chara_unknown()
	character2DFull(Tyrfing, "Tyrfing", 101001001)

--キラーズ体
	Tyrfing2 = set_chara_unknown()
	character2DFull(Tyrfing2, "Tyrfing2", 101001002)
end

--共通ルート
function setup2D_Gwenhwymawr()
--制服
	Gwenhwymawr = set_chara_unknown()
	character2DFull(Gwenhwymawr,"Gwenhwymawr", 101016001)

--キラーズ体
	Gwenhwymawr2 = set_chara_unknown()
	character2DFull(Gwenhwymawr2,"Gwenhwymawr2", 101016002)
end


function setup2D_Gawain()
	Gawain = set_chara_unknown()
	character2DFull(Gawain,"Gawain", 101013001)
	
	Gawain2 = set_chara_unknown()
	character2DFull(Gawain2,"Gawain2", 101013002)

end


function setup2D_Ragnar()
--制服
	Ragnar = set_chara_unknown()
	character2DFull(Ragnar,"Ragnar", 101018001)

--キラーズ体
	Ragnar2 = set_chara_unknown()
	character2DFull(Ragnar2,"Ragnar2", 101018002)
end


function setup2D_Brian()
	Brian = set_chara_unknown()
	character2DFull(Brian,"Brian", 101050001)
end


-- 追加分
function setup2D_Elaine()
	Elaine = set_chara_unknown()
	character2DFull(Elaine,"Elaine", 101030001)

	Elaine2 = set_chara_unknown()
	character2DFull(Elaine2,"Elaine2", 101030002)

end


function setup2D_Lovein()
	Lovein = set_chara_unknown()
	character2DFull(Lovein,"Lovein", 101031001)

	Lovein2 = set_chara_unknown()
	character2DFull(Lovein2,"Lovein2", 101031002)
end


function setup2D_Arthur()
	Arthur = set_chara_unknown()
	character2DFull(Arthur,"Arthur", 101015001)

	Arthur2 = set_chara_unknown()
	character2DFull(Arthur2,"Arthur2", 101015002)
	
	Arthur3 = set_chara_unknown()
	character2DFull(Arthur3,"Arthur3", 101015003)

end


function setup2D_Merlin()
	Merlin = set_chara_unknown()
	character2DFull(Merlin,"Merlin", 101020001)

	Merlin2 = set_chara_unknown()
	character2DFull(Merlin2,"Merlin2", 101020002)
end


function setup2D_Percival()
	Percival = set_chara_unknown()
	character2DFull(Percival,"Percival", 101026001)
end


function setup2D_Dindrane()
	Dindrane = set_chara_unknown()
	character2DFull(Dindrane,"Dindrane", 101027001)

	Dindrane2 = set_chara_unknown()
	character2DFull(Dindrane2,"Dindrane2", 101027002)
end


function setup2D_Galahad()
	Galahad = set_chara_unknown()
	character2DFull(Galahad,"Galahad", 101028001)

	Galahad2 = set_chara_unknown()
	character2DFull(Galahad2,"Galahad2", 101028002)

	Galahad3 = set_chara_unknown()
	character2DFull(Galahad3,"Galahad3", 101028003)

	Galahad4 = set_chara_unknown()
	character2DFull(Galahad4,"Galahad4", 101028004)
end


function setup2D_Viena()
	Viena = set_chara_unknown()
	character2DFull(Viena,"Viena", 101036001)

	Viena2 = set_chara_unknown()
	character2DFull(Viena2,"Viena2", 101036002)
end

function setup2D_Gareth()
	Gareth = set_chara_unknown()
	character2DFull(Gareth,"Gareth", 101032001)

	Gareth2 = set_chara_unknown()
	character2DFull(Gareth2,"Gareth2", 101032002)
end

function setup2D_BRUNO()
	BRUNO = set_chara_unknown()
	character2DFull(BRUNO,"BRUNO", 101021001)

	BRUNO2 = set_chara_unknown()
	character2DFull(BRUNO2,"BRUNO2", 101021002)

	BRUNO3 = set_chara_unknown()
	character2DFull(BRUNO3,"BRUNO3", 101021003)
end

function setup2D_Lucius()
	Lucius = set_chara_unknown()
	character2DFull(Lucius,"Lucius", 101051001)

	Lucius2 = set_chara_unknown()
	character2DFull(Lucius2,"Lucius2", 101051002)

	Lucius3 = set_chara_unknown()
	character2DFull(Lucius3,"Lucius3", 101051003)
end

function setup2D_Vernarth()
	Vernarth = set_chara_unknown()
	character2DFull(Vernarth,"Vernarth", 101052001)
end


function setup2D_Rasia()
	Rasia = set_chara_unknown()
	character2DFull(Rasia,"Rasia", 101037001)

	Rasia2 = set_chara_unknown()
	character2DFull(Rasia2,"Rasia2", 101037002)
end


function setup2D_Fren()
	Fren = set_chara_unknown()
	character2DFull(Fren,"Fren", 101039001)

	Fren2 = set_chara_unknown()
	character2DFull(Fren2,"Fren2", 101039002)

	Fren3 = set_chara_unknown()
	character2DFull(Fren3,"Fren3", 101039003)

end


function setup2D_Lola()
	Lola = set_chara_unknown()
	character2DFull(Lola,"Lola", 101038001)

	Lola2 = set_chara_unknown()
	character2DFull(Lola2,"Lola2", 101038002)

	Lola3 = set_chara_unknown()
	character2DFull(Lola3,"Lola3", 101038003)
end


function setup2D_Morgan()
	Morgan = set_chara_unknown()
	character2DFull(Morgan,"Morgan", 101041001)

	Morgan2 = set_chara_unknown()
	character2DFull(Morgan2,"Morgan2", 101041002)
end


function setup2D_Sisters_1()
	Sisters_1 = set_chara_unknown()
	character2DFull(Sisters_1,"Sisters_1", 101042001)
end


function setup2D_Sisters_2()
	Sisters_2 = set_chara_unknown()
	character2DFull(Sisters_2,"Sisters_2", 101043001)
end


function setup2D_Sisters_3()
	Sisters_3 = set_chara_unknown()
	character2DFull(Sisters_3,"Sisters_3", 101044001)
end


function setup2D_Sisters_4()
	Sisters_4 = set_chara_unknown()
	character2DFull(Sisters_4,"Sisters_4", 101045001)
end


function setup2D_Sisters_5()
	Sisters_5 = set_chara_unknown()
	character2DFull(Sisters_5,"Sisters_5", 101046001)
end


function setup2D_Sisters_6()
	Sisters_6 = set_chara_unknown()
	character2DFull(Sisters_6,"Sisters_6", 101047001)
end


function setup2D_Sisters_7()
	Sisters_7 = set_chara_unknown()
	character2DFull(Sisters_7,"Sisters_7", 101048001)
end

function setup2D_Sisters_8()
	Sisters_8 = set_chara_unknown()
	character2DFull(Sisters_8,"Sisters_8", 101049001)
end

function setup2D_MOB01_Soldier()

	MOB01_Soldier1 = set_chara_unknown()
	character2DFull(MOB01_Soldier1,"MOB01_Soldier1", 401035001)

	MOB01_Soldier2 = set_chara_unknown()
	character2DFull(MOB01_Soldier2,"MOB01_Soldier2", 401038001)

	MOB01_Soldier4 = set_chara_unknown()
	character2DFull(MOB01_Soldier4,"MOB01_Soldier4", 401037001)

	MOB01_Soldier5 = set_chara_unknown()
	character2DFull(MOB01_Soldier5,"MOB01_Soldier5", 401040001)

	MOB01_Soldier6 = set_chara_unknown()
	character2DFull(MOB01_Soldier6,"MOB01_Soldier6", 401039001)

	MOB01_Soldier7 = set_chara_unknown()
	character2DFull(MOB01_Soldier7,"MOB01_Soldier7", 401036001)
end

function setup2D_Astera()
	Astera = set_chara_unknown()
	character2DFull(Astera,"Astera", 101029001)

	Astera2 = set_chara_unknown()
	character2DFull(Astera2,"Astera2", 101029002)
end

function setup2D_Laiens()
	Laiens = set_chara_unknown()
	character2DFull(Laiens,"Laiens", 101058001)

	Laiens2 = set_chara_unknown()
	character2DFull(Laiens2,"Laiens2", 101058002)
end

function setup2D_Lyoness()
	Lyoness = set_chara_unknown()
	character2DFull(Lyoness,"Lyoness", 101033001)

	Lyoness2 = set_chara_unknown()
	character2DFull(Lyoness2,"Lyoness2", 101033002)
end

function setup2D_Maladisant()
	Maladisant = set_chara_unknown()
	character2DFull(Maladisant,"Maladisant", 101017001)

	Maladisant2 = set_chara_unknown()
	character2DFull(Maladisant2,"Maladisant2", 101017002)
end

function setup2D_Perez()
	Perez = set_chara_unknown()
	character2DFull(Perez,"Perez", 101056001)

	Perez2 = set_chara_unknown()
	character2DFull(Perez2,"Perez2", 101056002)
end

function setup2D_Kay()
	Kay = set_chara_unknown()
	character2DFull(Kay,"Kay", 101040001)

end

--キズナクエスト用
function setup2D_Mordred()
	Mordred = set_chara_unknown()
	character2DFull(Mordred,"Mordred", 101022001)
end


function setup2D_Clarice()
--制服
	Clarice = set_chara_unknown()
	character2DFull(Clarice,"Clarice", 101023001)

--キラーズ体
	Clarice2 = set_chara_unknown()
	character2DFull(Clarice2,"Clarice2", 101023002)
end


function setup2D_Bors()
	Bors = set_chara_unknown()
	character2DFull(Bors,"Bors", 101024001)
end


function setup2D_Clare()
--制服
 	Clare = set_chara_unknown()
 	character2DFull(Clare,"Clare", 101025001)

--キラーズ体
	 Clare2 = set_chara_unknown()
	 character2DFull(Clare2,"Clare2", 101025002)
end


function setup2D_Liliana()
--通常体
	Liliana = set_chara_unknown()
	character2DFull(Liliana,"Liliana", 101035001)

--キラーズ体
	Liliana2 = set_chara_unknown()
	character2DFull(Liliana2,"Liliana2", 101035002)
end


function setup2D_Excelia()
--通常体
	Excelia = set_chara_unknown()
	character2DFull(Excelia,"Excelia", 101034001)

--キラーズ体
	Excelia2 = set_chara_unknown()
	character2DFull(Excelia2,"Excelia2", 101034002)
end


function setup2D_Christina()
	Christina = set_chara_unknown()
	character2DFull(Christina,"Christina", 101063001)
end


function setup2D_Tristan()
	Tristan = set_chara_unknown()
	character2DFull(Tristan,"Tristan", 101014001)
end


function setup2D_Isolde()
--通常体
	Isolde = set_chara_unknown()
	character2DFull(Isolde,"Isolde", 101019001)

--キラーズ体
	Isolde2 = set_chara_unknown()
	character2DFull(Isolde2,"Isolde2", 101019002)
end

function setup2D_Laevatein()
--キラーズ体
	Laevatein = set_chara_unknown()
	character2DFull(Laevatein,"Laevatein", 101002001)

--通常体
	Laevatein2 = set_chara_unknown()
	character2DFull(Laevatein2,"Laevatein2", 101002002)
end

-- フライクーゲル初期化
function setup2D_Freikugel()
--通常体
	Freikugel = set_chara_unknown()
	character2DFull(Freikugel,"Freikugel", 101070001)
--キラーズ体
	Freikugel2 = set_chara_unknown()
	character2DFull(Freikugel2,"Freikugel2", 101070002)
end

-- アルハン初期化
function setup2D_Alham()
	Alham = set_chara_unknown()
	character2DFull(Alham,"Alham", 101059001)
end


function setup2D_Mathajim()
	Mathajim = set_chara_unknown()
	character2DFull(Mathajim,"Mathajim", 101053001)
end


function setup2D_Adam()
	Adam = set_chara_unknown()
	character2DFull(Adam,"Adam", 101054001)
end


function setup2D_Owen()
	Owen = set_chara_unknown()
	character2DFull(Owen,"Owen", 101055001)
end


function area_setup_101009_Noir_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101noir", "MotionPack_101Noir", "content_animationpack__common", "FacialPack")
	character2DFull_Preload(label, "Noir", 101009002)
	if pose ~= nil then
	end
end

function area_setup_101001_Tyrfing_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101tyrf", "MotionPack_101Tyrf", "content_animationpack__common", "FacialPack")
	character2DFull_Preload(label, "Tyrfing", 101001001)
	if pose ~= nil then
	end
end

function area_setup_101010_Lancelot_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101lanc", "MotionPack_101Lanc", "content_animationpack__common", "FacialPack")
	character2DFull_Preload(label, "Lancelot", 101010001)
	if pose ~= nil then
	end
end

function area_setup_101011_Guinevere_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101guin", "MotionPack_101Guin", "content_animationpack__common", "FacialPack")
	character2DFull_Preload(label, "Guinevere", 101011001)
	if pose ~= nil then
	end
end

function area_setup_101012_Dinatan_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101dina", "MotionPack_101Dina", "content_animationpack__common", "FacialPack")
	character2DFull_Preload(label, "Dinatan", 101012001)
	if pose ~= nil then
	end
end

function area_setup_101013_Gawain_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101gawa", "MotionPack_101Gawa", "content_animationpack__common", "FacialPack")
	character2DFull_Preload(label, "Gawain", 101013001)
	if pose ~= nil then
	end
end

function area_setup_101016_Gwenhwymawr_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101gwen", "MotionPack_101Gwen", "content_animationpack__common", "FacialPack")
	character2DFull_Preload(label, "Gwenhwymawr", 101016001)
	if pose ~= nil then
	end
end

function area_setup_101017_Maladisant_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101mala", "MotionPack_101Mala", "content_animationpack__common", "FacialPack")
	character2DFull_Preload(label, "Maladisant", 101017001)
	if pose ~= nil then
	end
end

function area_setup_101018_Ragnar_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101ragn", "MotionPack_101Ragn", "content_animationpack__common", "FacialPack")
	character2DFull_Preload(label, "Ragnar", 101018001)
	if pose ~= nil then
	end
end

function area_setup_101015_Arthur_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101arth", "MotionPack_101Arth", "content_animationpack__common", "FacialPack")
	character2DMinimum_Preload(label, "Arthur", 101015001)
	if pose ~= nil then
	end
end

function area_setup_101030_Elaine_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101elai", "MotionPack_101Elai", "content_animationpack__common", "FacialPack")
	character2DMinimum_Preload(label, "Elaine", 101030001)
	if pose ~= nil then
	end
end

function area_setup_101040_Kay_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101kay", "MotionPack_101Kay", "content_animationpack__common", "FacialPack")
	character2DMinimum_Preload(label, "Kay", 101040001)
	if pose ~= nil then
	end
end

function area_setup_101041_Morgan_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101morg", "MotionPack_101Morg", "content_animationpack__common", "FacialPack")
	character2DMinimum_Preload(label, "Morgan", 101041001)
	if pose ~= nil then
	end
end

function area_setup_101062_Maril_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101mari", "MotionPack_101Mari", "content_animationpack__common", "FacialPack")
	character2DMinimum_Preload(label, "Maril", 101062001)
	if pose ~= nil then
	end
end

function area_setup_101063_Christina_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101chri", "MotionPack_101Chri", "content_animationpack__common", "FacialPack")
	character2DMinimum_Preload(label, "Christina", 101063001)
	if pose ~= nil then
	end
end

function area_setup_101064_Liam_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_101_101liam", "MotionPack_101Liam", "content_animationpack__common", "FacialPack")
	character2DMinimum_Preload(label, "Liam", 101064001)
	if pose ~= nil then
	end
end

function area_setup_MOB01_M_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_100_100mobm", "MotionPack_100MobM", "content_animationpack__common", "FacialPack")
	if pose ~= nil then
	end
end

function area_setup_MOB01_F_preload(target, pose)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	get_chara_preload(target, "content_animationpack_100_100mobf", "MotionPack_100MobF", "content_animationpack__common", "FacialPack")
	if pose ~= nil then
	end
end

function setup_Noir_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Sri_Std_loop_m", "Normal")
	character2DDefaultStyleFull_Preload(Noir, "Noir",101009)
end

function setup_Noir2_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101009_101009001_model", "101009001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Sri_Std_loop_m", "Normal")
	character2DFull_Preload(Noir, "Noir",101009001)
end

function setup_Lancelot_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101010_101010001_model", "101010001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Col_Std_loop_m", "Normal")
	character2DFull_Preload(Lancelot, "Lancelot", 101010001)
end

function setup_Guinevere_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101011_101011001_model", "101011001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Nbl_Std_loop_f", "Normal")
	character2DFull_Preload(Guinevere, "Guinevere", 101011001)
end

function setup_Dinatan_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101012_101012001_model", "101012001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Nbl_Std_loop_f", "Normal")
	character2DFull_Preload(Dinatan, "Dinatan", 101012001)
end

function setup_Tyrfing_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101001_101001001_model", "101001001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Nbl_Std_loop_f", "Normal")
	character2DFull_Preload(Tyrfing, "Tyrfing", 101001001)
end

function setup_Morgan_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101041_101041001_model", "101041001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
	character2DMinimum_Preload(Morgan, "Morgan", 101041001)
end

function setup_Arthur_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101015_101015001_model", "101015001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	character2DMinimum_Preload(Arthur, "Arthur", 101015001)
end

function setup_Kay_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101040_101040001_model", "101040001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	character2DMinimum_Preload(Kay, "Kay", 101040001)
end

function setup_Gawain_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101013_101013001_model", "101013001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	character2DMinimum_Preload(Gawain, "Gawain", 101013001)
end

function setup_Ragnar_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101018_101018001_model", "101018001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
	character2DMinimum_Preload(Ragnar, "Ragnar", 101018001)
end

function setup_Gwenhwymawr_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101016_101016001_model", "101016001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
	character2DMinimum_Preload(Gwenhwymawr, "Gwenhwymawr", 101016001)
end

function setup_Maladisant_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101017_101017001_model", "101017001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
	character2DMinimum_Preload(Maladisant, "Maladisant", 101017001)
end

function setup_Moronoe_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101042_101042001_model", "101042001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
	character2DMinimum_Preload(Moronoe, "Moronoe", 101042001)
end

function setup_MOB_StudentB_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	set_chara_preload("content_chr_401005_401005001_model", "401005001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
end

function setup_MOB_StudentG_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_f", "Normal")
end

function setup_MOB_Soldier_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	set_chara_preload("content_chr_401036_401036001_model", "401036001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
end

function setup_MOB_CitizenM_preload(pos)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local label
	set_chara_preload("content_chr_401011_401011001_model", "401011001_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", pos, "Mob_Std_loop_m", "Normal")
end

function setup2D_Noir_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Noir, "Noir", 101009002)
	character2DFull_Preload(Noir2, "Noir2", 101009001)
	character2DFull_Preload(Noir3, "Noir3", 101009003)
end

function setup2D_Lancelot_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Lancelot, "Lancelot", 101010001)
	character2DFull_Preload(Lancelot2, "Lancelot2", 101010002)
	character2DFull_Preload(Lancelot3, "Lancelot3", 101010007)
end

function setup2D_Guinevere_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Guinevere, "Guinevere", 101011001)
	character2DFull_Preload(Guinevere2, "Guinevere2", 101011002)
	character2DFull_Preload(Guinevere3, "Guinevere3", 101011007)
end

function setup2D_Dinatan_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Dinatan, "Dinatan", 101012001)
	character2DFull_Preload(Dinatan2, "Dinatan2", 101012002)
	character2DFull_Preload(Dinatan3, "Dinatan3", 101012003)
	character2DFull_Preload(Dinatan4, "Dinatan4", 101012008)
end

function setup2D_Tyrfing_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Tyrfing, "Tyrfing", 101001001)
	character2DFull_Preload(Tyrfing2, "Tyrfing2", 101001002)
end

function setup2D_Gwenhwymawr_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Gwenhwymawr,"Gwenhwymawr", 101016001)
	character2DFull_Preload(Gwenhwymawr2,"Gwenhwymawr2", 101016002)
end

function setup2D_Gawain_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Gawain,"Gawain", 101013001)
end

function setup2D_Ragnar_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Ragnar,"Ragnar", 101018001)
	character2DFull_Preload(Ragnar2,"Ragnar2", 101018002)
end

function setup2D_Brian_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Brian,"Brian", 101050001)
end

function setup2D_Elaine_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Elaine,"Elaine", 101030001)
end

function setup2D_Lovein_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Lovein,"Lovein", 101031001)
	character2DFull_Preload(Lovein2,"Lovein2", 101031002)
end

function setup2D_Arthur_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Arthur,"Arthur", 101015001)
	character2DFull_Preload(Arthur2,"Arthur2", 101015002)
end

function setup2D_Merlin_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Merlin,"Merlin", 101020001)
	character2DFull_Preload(Merlin2,"Merlin2", 101020002)
end

function setup2D_Percival_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Percival,"Percival", 101026001)
end

function setup2D_Dindrane_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Dindrane,"Dindrane", 101027001)
	character2DFull_Preload(Dindrane2,"Dindrane2", 101027002)
end

function setup2D_Galahad_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Galahad,"Galahad", 101028001)
	character2DFull_Preload(Galahad2,"Galahad2", 101028002)
	character2DFull_Preload(Galahad3,"Galahad3", 101028003)
	character2DFull_Preload(Galahad4,"Galahad4", 101028004)
end

function setup2D_Viena_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Viena,"Viena", 101036001)
	character2DFull_Preload(Viena2,"Viena2", 101036002)
end

function setup2D_Gareth_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Gareth,"Gareth", 101032001)
	character2DFull_Preload(Gareth2,"Gareth2", 101032002)
end

function setup2D_BRUNO_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(BRUNO,"BRUNO", 101021001)
	character2DFull_Preload(BRUNO2,"BRUNO2", 101021002)
	character2DFull_Preload(BRUNO3,"BRUNO3", 101021003)
end

function setup2D_Lucius_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Lucius,"Lucius", 101051001)
	character2DFull_Preload(Lucius2,"Lucius2", 101051002)
	character2DFull_Preload(Lucius3,"Lucius3", 101051003)
end

function setup2D_Vernarth_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Vernarth,"Vernarth", 101052001)
end

function setup2D_Rasia_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Rasia,"Rasia", 101037001)
	character2DFull_Preload(Rasia2,"Rasia2", 101037002)
end

function setup2D_Fren_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Fren,"Fren", 101039001)
	character2DFull_Preload(Fren2,"Fren2", 101039002)
end

function setup2D_Lola_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Lola,"Lola", 101038001)
	character2DFull_Preload(Lola2,"Lola2", 101038002)
end

function setup2D_Morgan_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Morgan,"Morgan", 101041001)
	character2DFull_Preload(Morgan2,"Morgan2", 101041002)
end

function setup2D_Sisters_1_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_1,"Sisters_1", 101042001)
end

function setup2D_Sisters_2_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_2,"Sisters_2", 101043001)
end

function setup2D_Sisters_3_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_3,"Sisters_3", 101044001)
end

function setup2D_Sisters_4_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_4,"Sisters_4", 101045001)
end

function setup2D_Sisters_5_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_5,"Sisters_5", 101046001)
end

function setup2D_Sisters_6_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_6,"Sisters_6", 101047001)
end

function setup2D_Sisters_7_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_7,"Sisters_7", 101048001)
end

function setup2D_Sisters_8_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_8,"Sisters_8", 101049001)
end

function setup2D_MOB01_Soldier_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(MOB01_Soldier1,"MOB01_Soldier1", 401035001)
	character2DFull_Preload(MOB01_Soldier2,"MOB01_Soldier2", 401038001)
	character2DFull_Preload(MOB01_Soldier4,"MOB01_Soldier4", 401037001)
	character2DFull_Preload(MOB01_Soldier5,"MOB01_Soldier5", 401040001)
	character2DFull_Preload(MOB01_Soldier6,"MOB01_Soldier6", 401039001)
	character2DFull_Preload(MOB01_Soldier7,"MOB01_Soldier7", 401036001)
end

function setup2D_Astera_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Astera,"Astera", 101029001)
	character2DFull_Preload(Astera2,"Astera2", 101029002)
end

function setup2D_Laiens_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Laiens,"Laiens", 101058001)
	character2DFull_Preload(Laiens2,"Laiens2", 101058002)
end

function setup2D_Lyoness_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Lyoness,"Lyoness", 101033001)
	character2DFull_Preload(Lyoness2,"Lyoness2", 101033002)
end

function setup2D_Maladisant_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Maladisant,"Maladisant", 101017001)
	character2DFull_Preload(Maladisant2,"Maladisant2", 101017002)
end

function setup2D_Perez_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Perez,"Perez", 101056001)
	character2DFull_Preload(Perez2,"Perez2", 101056002)
end

function setup2D_Kay_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Kay,"Kay", 101040001)
end

function setup2D_Mordred_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Mordred,"Mordred", 101022001)
end

function setup2D_Clarice_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Clarice,"Clarice", 101023001)
	character2DFull_Preload(Clarice2,"Clarice2", 101023002)
end

function setup2D_Bors_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Bors,"Bors", 101024001)
end

function setup2D_Clare_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
 	character2DFull_Preload(Clare,"Clare", 101025001)
	 character2DFull_Preload(Clare2,"Clare2", 101025002)
end

function setup2D_Liliana_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Liliana,"Liliana", 101035001)
	character2DFull_Preload(Liliana2,"Liliana2", 101035002)
end

function setup2D_Excelia_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Excelia,"Excelia", 101034001)
	character2DFull_Preload(Excelia2,"Excelia2", 101034002)
end

function setup2D_Christina_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Christina,"Christina", 101063001)
end

function setup2D_Tristan_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Tristan,"Tristan", 101014001)
end

function setup2D_Isolde_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Isolde,"Isolde", 101019001)
	character2DFull_Preload(Isolde2,"Isolde2", 101019002)
end

function setup2D_Laevatein_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Laevatein,"Laevatein", 101002001)
	character2DFull_Preload(Laevatein2,"Laevatein2", 101002002)
end

function setup2D_Freikugel_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Freikugel,"Freikugel", 101070001)
	character2DFull_Preload(Freikugel2,"Freikugel2", 101070002)
end

function setup2D_Alham_preload()
	character2DFull_Preload(Alham,"Alham", 101059001)
end	

function setup2D_Mathajim_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Mathajim,"Mathajim", 101053001)
end

function setup2D_Adam_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Adam,"Adam", 101054001)
end

function setup2D_Owen_preload()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Owen,"Owen", 101055001)
end





-----------------------------------------------------------------------------------------------------------------------

-- setup2Dをスタイル指定形式にした新関数 ------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------------------

function setup2D_S_Noir(style)
	if style == 2 then	--制服・金コート
		Noir2 = set_chara_unknown()
		character2DFull(Noir2, "Noir2", 101009001)
	elseif style == 3 then	--傭兵
		Noir3 = set_chara_unknown()
		character2DFull(Noir3, "Noir3", 101009003)
	elseif style == 9 then	--シルエット
		Noir9 = set_chara_unknown()
		character2DFull(Noir9, "Noir9", 101009009)
	else	--制服
		Noir = set_chara_unknown()
		character2DFull(Noir, "Noir", 101009002)
	end
end

function setup2D_S_Noir_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--制服・金コート
		character2DFull_Preload(Noir2, "Noir2", 101009001)
	elseif style == 3 then	--傭兵
		character2DFull_Preload(Noir3, "Noir3", 101009003)
	elseif style == 9 then	--シルエット
		character2DFull_Preload(Noir9, "Noir9", 101009009)
	else	--制服
		character2DFull_Preload(Noir, "Noir", 101009002)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Lancelot(style)
	if style == 2 then	--キラーズ体
		Lancelot2 = set_chara_unknown()
		character2DFull(Lancelot2, "Lancelot2", 101010002)
	elseif style == 3 then	--イミテーション
		Lancelot3 = set_chara_unknown()
		character2DFull(Lancelot3, "Lancelot3", 101010007)
	else	--通常体
		Lancelot = set_chara_unknown()
		character2DFull(Lancelot, "Lancelot", 101010001)
	end
end

function setup2D_S_Lancelot_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Lancelot2, "Lancelot2", 101010002)
	elseif style == 3 then	--イミテーション
		character2DFull_Preload(Lancelot3, "Lancelot3", 101010007)
	else	--通常体
		character2DFull_Preload(Lancelot, "Lancelot", 101010001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Guinevere(style)
	if style == 2 then	--キラーズ体
		Guinevere2 = set_chara_unknown()
		character2DFull(Guinevere2, "Guinevere2", 101011002)
	elseif style == 3 then	--イミテーション
		Guinevere3 = set_chara_unknown()
		character2DFull(Guinevere3, "Guinevere3", 101011007)
	else	--通常体
		Guinevere = set_chara_unknown()
		character2DFull(Guinevere, "Guinevere", 101011001)
	end
end

function setup2D_S_Guinevere_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Guinevere2, "Guinevere2", 101011002)
	elseif style == 3 then	--イミテーション
		character2DFull_Preload(Guinevere3, "Guinevere3", 101011007)
	else	--通常体
		character2DFull_Preload(Guinevere, "Guinevere", 101011001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Dinatan(style)
	if style == 2 then	--キラーズ体
		Dinatan2 = set_chara_unknown()
		character2DFull(Dinatan2, "Dinatan2", 101012002)
	elseif style == 3 then	--連合軍
		Dinatan3 = set_chara_unknown()
		character2DFull(Dinatan3, "Dinatan3", 101012003)
	elseif style == 4 then	--イミテーション
		Dinatan4 = set_chara_unknown()
		character2DFull(Dinatan4, "Dinatan4", 101012008)
	else	--通常体
		Dinatan = set_chara_unknown()
		character2DFull(Dinatan, "Dinatan", 101012001)
	end
end

function setup2D_S_Dinatan_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Dinatan2, "Dinatan2", 101012002)
	elseif style == 3 then	--連合軍
		character2DFull_Preload(Dinatan3, "Dinatan3", 101012003)
	elseif style == 4 then	--イミテーション
		character2DFull_Preload(Dinatan4, "Dinatan4", 101012008)
	else	--通常体
		character2DFull_Preload(Dinatan, "Dinatan", 101012001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Tyrfing(style)
	if style == 2 then	--キラーズ体
		Tyrfing2 = set_chara_unknown()
		character2DFull(Tyrfing2, "Tyrfing2", 101001002)
	else	--通常体
		Tyrfing = set_chara_unknown()
		character2DFull(Tyrfing, "Tyrfing", 101001001)
	end
end

function setup2D_S_Tyrfing_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Tyrfing2, "Tyrfing2", 101001002)
	else	--通常体
		character2DFull_Preload(Tyrfing, "Tyrfing", 101001001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Gwenhwymawr(style)
	if style == 2 then	--キラーズ体
		Gwenhwymawr2 = set_chara_unknown()
		character2DFull(Gwenhwymawr2,"Gwenhwymawr2", 101016002)
	else	--制服
		Gwenhwymawr = set_chara_unknown()
		character2DFull(Gwenhwymawr,"Gwenhwymawr", 101016001)
	end
end

function setup2D_S_Gwenhwymawr_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Gwenhwymawr2,"Gwenhwymawr2", 101016002)
	else	--制服
		character2DFull_Preload(Gwenhwymawr,"Gwenhwymawr", 101016001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Gawain(style)
	if style == 2 then	--敵対峙
		Gawain2 = set_chara_unknown()
		character2DFull(Gawain2,"Gawain2", 101013002)
	else	--制服
		Gawain = set_chara_unknown()
		character2DFull(Gawain,"Gawain", 101013001)
	end
end

function setup2D_S_Gawain_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--敵対峙
		character2DFull_Preload(Gawain2,"Gawain2", 101013002)
	else	--制服
		character2DFull_Preload(Gawain,"Gawain", 101013001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Ragnar(style)
	if style == 2 then	--キラーズ体
		Ragnar2 = set_chara_unknown()
		character2DFull(Ragnar2,"Ragnar2", 101018002)
	else	--制服
		Ragnar = set_chara_unknown()
		character2DFull(Ragnar,"Ragnar", 101018001)
	end
end

function setup2D_S_Ragnar_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Ragnar2,"Ragnar2", 101018002)
	else	--制服
		character2DFull_Preload(Ragnar,"Ragnar", 101018001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Brian(style)
	Brian = set_chara_unknown()
	character2DFull(Brian,"Brian", 101050001)
end

function setup2D_S_Brian_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Brian,"Brian", 101050001)
end

-------------------------------------------------------------------------------

function setup2D_S_Elaine(style)
	if style == 2 then	--制服（傷あり）
		Elaine2 = set_chara_unknown()
		character2DFull(Elaine2,"Elaine2", 101030002)
	elseif style == 3 then	--ドレス
		Elaine3 = set_chara_unknown()
		character2DFull(Elaine3,"Elaine3", 101030003)
	elseif style == 5 then	--魔導書版
		Elaine5 = set_chara_unknown()
		character2DFull(Elaine5,"Elaine5", 101030005)
	elseif style == 7 then	--シルエット
		Elaine7 = set_chara_unknown()
		character2DFull(Elaine7,"Elaine7", 101030007)
	else	--制服（傷なし）
		Elaine = set_chara_unknown()
		character2DFull(Elaine,"Elaine", 101030001)
	end
end

function setup2D_S_Elaine_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--制服（傷あり）
		character2DFull_Preload(Elaine2,"Elaine2", 101030002)
	elseif style == 3 then	--ドレス
		character2DFull_Preload(Elaine3,"Elaine3", 101030003)
	elseif style == 5 then	--魔導書版
		character2DFull_Preload(Elaine5,"Elaine5", 101030005)
	elseif style == 7 then	--シルエット
		character2DFull_Preload(Elaine7,"Elaine7", 101030007)
	else	--制服（傷なし）
		character2DFull_Preload(Elaine,"Elaine", 101030001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Lovein(style)
	if style == 2 then	--キラーズ体
		Lovein2 = set_chara_unknown()
		character2DFull(Lovein2,"Lovein2", 101031002)
	elseif style == 3 then	--シルエット
		Lovein3 = set_chara_unknown()
		character2DFull(Lovein3,"Lovein3", 101031003)
	else	--制服
		Lovein = set_chara_unknown()
		character2DFull(Lovein,"Lovein", 101031001)
	end
end

function setup2D_S_Lovein_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Lovein2,"Lovein2", 101031002)
	elseif style == 3 then	--シルエット
		character2DFull_Preload(Lovein3,"Lovein3", 101031003)
	else	--制服
		character2DFull_Preload(Lovein,"Lovein", 101031001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Arthur(style)
	if style == 2 then	--バルバロイ化
		Arthur2 = set_chara_unknown()
		character2DFull(Arthur2,"Arthur2", 101015002)
	elseif style == 3 then	--敵対峙
		Arthur3 = set_chara_unknown()
		character2DFull(Arthur3,"Arthur3", 101015003)
	else	--通常
		Arthur = set_chara_unknown()
		character2DFull(Arthur,"Arthur", 101015001)
	end
end

function setup2D_S_Arthur_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--バルバロイ化
		character2DFull_Preload(Arthur2,"Arthur2", 101015002)
	elseif style == 3 then	--敵対峙
		character2DFull_Preload(Arthur3,"Arthur3", 101015003)
	else	--通常
		character2DFull_Preload(Arthur,"Arthur", 101015001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Merlin(style)
	if style == 2 then	--キラーズ体
		Merlin2 = set_chara_unknown()
		character2DFull(Merlin2,"Merlin2", 101020002)
	else	--通常
		Merlin = set_chara_unknown()
		character2DFull(Merlin,"Merlin", 101020001)
	end
end

function setup2D_S_Merlin_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Merlin2,"Merlin2", 101020002)
	else	--通常
		character2DFull_Preload(Merlin,"Merlin", 101020001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Percival(style)
	Percival = set_chara_unknown()
	character2DFull(Percival,"Percival", 101026001)
end

function setup2D_S_Percival_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Percival,"Percival", 101026001)
end

-------------------------------------------------------------------------------

function setup2D_S_Dindrane(style)
	if style == 2 then	--キラーズ体
		Dindrane2 = set_chara_unknown()
		character2DFull(Dindrane2,"Dindrane2", 101027002)
	else	--通常
		Dindrane = set_chara_unknown()
		character2DFull(Dindrane,"Dindrane", 101027001)
	end
end

function setup2D_S_Dindrane_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Dindrane2,"Dindrane2", 101027002)
	else	--通常
		character2DFull_Preload(Dindrane,"Dindrane", 101027001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Galahad(style)
	if style == 2 then	--鎧＋兜なし
		Galahad2 = set_chara_unknown()
		character2DFull(Galahad2,"Galahad2", 101028002)
	elseif style == 3 then	--鎧＋兜あり
		Galahad3 = set_chara_unknown()
		character2DFull(Galahad3,"Galahad3", 101028003)
	elseif style == 4 then	--暴走
		Galahad4 = set_chara_unknown()
		character2DFull(Galahad4,"Galahad4", 101028004)
	else	--制服
		Galahad = set_chara_unknown()
		character2DFull(Galahad,"Galahad", 101028001)
	end
end

function setup2D_S_Galahad_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--鎧＋兜なし
		character2DFull_Preload(Galahad2,"Galahad2", 101028002)
	elseif style == 3 then	--鎧＋兜あり
		character2DFull_Preload(Galahad3,"Galahad3", 101028003)
	elseif style == 4 then	--暴走
		character2DFull_Preload(Galahad4,"Galahad4", 101028004)
	else	--制服
		character2DFull_Preload(Galahad,"Galahad", 101028001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Viena(style)
	if style == 2 then	--キラーズ体
		Viena2 = set_chara_unknown()
		character2DFull(Viena2,"Viena2", 101036002)
	else	--通常
		Viena = set_chara_unknown()
		character2DFull(Viena,"Viena", 101036001)
	end
end

function setup2D_S_Viena_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Viena2,"Viena2", 101036002)
	else	--通常
		character2DFull_Preload(Viena,"Viena", 101036001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Gareth(style)
	Gareth = set_chara_unknown()
	character2DFull(Gareth,"Gareth", 101032001)
end

function setup2D_S_Gareth_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Gareth,"Gareth", 101032001)
end

-------------------------------------------------------------------------------

function setup2D_S_BRUNO(style)
	if style == 2 then	--キラーズ体（仮面なし）
		BRUNO2 = set_chara_unknown()
		character2DFull(BRUNO2,"BRUNO2", 101021002)
	elseif style == 3 then	--金コート
		BRUNO3 = set_chara_unknown()
		character2DFull(BRUNO3,"BRUNO3", 101021003)
	else	--キラーズ体（仮面あり）
		BRUNO = set_chara_unknown()
		character2DFull(BRUNO,"BRUNO", 101021001)
	end
end

function setup2D_S_BRUNO_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体（仮面なし）
		character2DFull_Preload(BRUNO2,"BRUNO2", 101021002)
	elseif style == 3 then	--金コート
		character2DFull_Preload(BRUNO3,"BRUNO3", 101021003)
	else	--キラーズ体（仮面あり）
		character2DFull_Preload(BRUNO,"BRUNO", 101021001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Lucius(style)
	if style == 2 then	--制服
		Lucius2 = set_chara_unknown()
		character2DFull(Lucius2,"Lucius2", 101051002)
	elseif style == 3 then	--バルバロイ化
		Lucius3 = set_chara_unknown()
		character2DFull(Lucius3,"Lucius3", 101051003)
	else	--皇帝
		Lucius = set_chara_unknown()
		character2DFull(Lucius,"Lucius", 101051001)
	end
end

function setup2D_S_Lucius_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--制服
		character2DFull_Preload(Lucius2,"Lucius2", 101051002)
	elseif style == 3 then	--バルバロイ化
		character2DFull_Preload(Lucius3,"Lucius3", 101051003)
	else	--皇帝
		character2DFull_Preload(Lucius,"Lucius", 101051001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Vernarth(style)
	Vernarth = set_chara_unknown()
	character2DFull(Vernarth,"Vernarth", 101052001)
end

function setup2D_S_Vernarth_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Vernarth,"Vernarth", 101052001)
end

-------------------------------------------------------------------------------

function setup2D_S_Rasia(style)
	if style == 2 then	--キラーズ体
		Rasia2 = set_chara_unknown()
		character2DFull(Rasia2,"Rasia2", 101037002)
	else	--制服
		Rasia = set_chara_unknown()
		character2DFull(Rasia,"Rasia", 101037001)
	end
end

function setup2D_S_Rasia_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Rasia2,"Rasia2", 101037002)
	else	--制服
		character2DFull_Preload(Rasia,"Rasia", 101037001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Fren(style)
	if style == 2 then	--キラーズ体
		Fren2 = set_chara_unknown()
		character2DFull(Fren2,"Fren2", 101039002)
	elseif style == 3 then	--バルバロイ化
		Fren3 = set_chara_unknown()
		character2DFull(Fren3,"Fren3", 101039003)
	else	--制服
		Fren = set_chara_unknown()
		character2DFull(Fren,"Fren", 101039001)
	end
end

function setup2D_S_Fren_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Fren2,"Fren2", 101039002)
	elseif style == 3 then	--バルバロイ化
		character2DFull_Preload(Fren3,"Fren3", 101039003)
	else	--制服
		character2DFull_Preload(Fren,"Fren", 101039001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Lola(style)
	if style == 2 then	--キラーズ体
		Lola2 = set_chara_unknown()
		character2DFull(Lola2,"Lola2", 101038002)
	elseif style == 3 then	--バルバロイ化
		Lola3 = set_chara_unknown()
		character2DFull(Lola3,"Lola3", 101038003)
	else	--制服
		Lola = set_chara_unknown()
		character2DFull(Lola,"Lola", 101038001)
	end
end

function setup2D_S_Lola_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Lola2,"Lola2", 101038002)
	elseif style == 3 then	--バルバロイ化
		character2DFull_Preload(Lola3,"Lola3", 101038003)
	else	--制服
		character2DFull_Preload(Lola,"Lola", 101038001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Morgan(style)
	if style == 2 then	--魔女化
		Morgan2 = set_chara_unknown()
		character2DFull(Morgan2,"Morgan2", 101041002)
	else	--通常
		Morgan = set_chara_unknown()
		character2DFull(Morgan,"Morgan", 101041001)
	end
end

function setup2D_S_Morgan_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--魔女化
		character2DFull_Preload(Morgan2,"Morgan2", 101041002)
	else	--通常
		character2DFull_Preload(Morgan,"Morgan", 101041001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Sisters_1(style)
	Sisters_1 = set_chara_unknown()
	character2DFull(Sisters_1,"Sisters_1", 101042001)
end

function setup2D_S_Sisters_1_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_1,"Sisters_1", 101042001)
end

-------------------------------------------------------------------------------

function setup2D_S_Sisters_2(style)
	Sisters_2 = set_chara_unknown()
	character2DFull(Sisters_2,"Sisters_2", 101043001)
end

function setup2D_S_Sisters_2_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_2,"Sisters_2", 101043001)
end

-------------------------------------------------------------------------------

function setup2D_S_Sisters_3(style)
	Sisters_3 = set_chara_unknown()
	character2DFull(Sisters_3,"Sisters_3", 101044001)
end

function setup2D_S_Sisters_3_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_3,"Sisters_3", 101044001)
end

-------------------------------------------------------------------------------

function setup2D_S_Sisters_4(style)
	Sisters_4 = set_chara_unknown()
	character2DFull(Sisters_4,"Sisters_4", 101045001)
end

function setup2D_S_Sisters_4_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_4,"Sisters_4", 101045001)
end

-------------------------------------------------------------------------------

function setup2D_S_Sisters_5(style)
	Sisters_5 = set_chara_unknown()
	character2DFull(Sisters_5,"Sisters_5", 101046001)
end

function setup2D_S_Sisters_5_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_5,"Sisters_5", 101046001)
end

-------------------------------------------------------------------------------

function setup2D_S_Sisters_6(style)
	Sisters_6 = set_chara_unknown()
	character2DFull(Sisters_6,"Sisters_6", 101047001)
end

function setup2D_S_Sisters_6_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_6,"Sisters_6", 101047001)
end

-------------------------------------------------------------------------------

function setup2D_S_Sisters_7(style)
	Sisters_7 = set_chara_unknown()
	character2DFull(Sisters_7,"Sisters_7", 101048001)
end

function setup2D_S_Sisters_7_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_7,"Sisters_7", 101048001)
end

-------------------------------------------------------------------------------

function setup2D_S_Sisters_8(style)
	Sisters_8 = set_chara_unknown()
	character2DFull(Sisters_8,"Sisters_8", 101049001)
end

function setup2D_S_Sisters_8_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Sisters_8,"Sisters_8", 101049001)
end

-------------------------------------------------------------------------------

function setup2D_S_MOB01_Soldier(style)
	if style == 2 then	--連合軍下位
		MOB01_Soldier2 = set_chara_unknown()
		character2DFull(MOB01_Soldier2,"MOB01_Soldier2", 401038001)
	elseif style == 4 then	--連合軍上位
		MOB01_Soldier4 = set_chara_unknown()
		character2DFull(MOB01_Soldier4,"MOB01_Soldier4", 401037001)
	elseif style == 5 then	--ローマ軍下位
		MOB01_Soldier5 = set_chara_unknown()
		character2DFull(MOB01_Soldier5,"MOB01_Soldier5", 401040001)
	elseif style == 6 then	--ローマ軍上位
		MOB01_Soldier6 = set_chara_unknown()
		character2DFull(MOB01_Soldier6,"MOB01_Soldier6", 401039001)
	elseif style == 7 then	--キャメロット軍下位
		MOB01_Soldier7 = set_chara_unknown()
		character2DFull(MOB01_Soldier7,"MOB01_Soldier7", 401036001)
	else	--キャメロット軍上位
		MOB01_Soldier1 = set_chara_unknown()
		character2DFull(MOB01_Soldier1,"MOB01_Soldier1", 401035001)
	end
end

function setup2D_S_MOB01_Soldier_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--連合軍下位
		character2DFull_Preload(MOB01_Soldier2,"MOB01_Soldier2", 401038001)
	elseif style == 4 then	--連合軍上位
		character2DFull_Preload(MOB01_Soldier4,"MOB01_Soldier4", 401037001)
	elseif style == 5 then	--ローマ軍下位
		character2DFull_Preload(MOB01_Soldier5,"MOB01_Soldier5", 401040001)
	elseif style == 6 then	--ローマ軍上位
		character2DFull_Preload(MOB01_Soldier6,"MOB01_Soldier6", 401039001)
	elseif style == 7 then	--キャメロット軍下位
		character2DFull_Preload(MOB01_Soldier7,"MOB01_Soldier7", 401036001)
	else	--キャメロット軍上位
		character2DFull_Preload(MOB01_Soldier1,"MOB01_Soldier1", 401035001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Astera(style)
	if style == 2 then	--キラーズ体
		Astera2 = set_chara_unknown()
		character2DFull(Astera2,"Astera2", 101029002)
	else	--傭兵
		Astera = set_chara_unknown()
		character2DFull(Astera,"Astera", 101029001)
	end
end

function setup2D_S_Astera_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Astera2,"Astera2", 101029002)
	else	--傭兵
		character2DFull_Preload(Astera,"Astera", 101029001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Laiens(style)
	if style == 2 then	--バルバロイ化
		Laiens2 = set_chara_unknown()
		character2DFull(Laiens2,"Laiens2", 101058002)
	else	--通常
		Laiens = set_chara_unknown()
		character2DFull(Laiens,"Laiens", 101058001)
	end
end

function setup2D_S_Laiens_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--バルバロイ化
		character2DFull_Preload(Laiens2,"Laiens2", 101058002)
	else	--通常
		character2DFull_Preload(Laiens,"Laiens", 101058001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S__Lyoness(style)
	if style == 2 then	--キラーズ体
		Lyoness2 = set_chara_unknown()
		character2DFull(Lyoness2,"Lyoness2", 101033002)
	else	--制服
		Lyoness = set_chara_unknown()
		character2DFull(Lyoness,"Lyoness", 101033001)
	end
end

function setup2D_S__Lyoness_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Lyoness2,"Lyoness2", 101033002)
	else	--制服
		character2DFull_Preload(Lyoness,"Lyoness", 101033001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Maladisant(style)
	if style == 2 then	--キラーズ体
		Maladisant2 = set_chara_unknown()
		character2DFull(Maladisant2,"Maladisant2", 101017002)
	else	--制服
		Maladisant = set_chara_unknown()
		character2DFull(Maladisant,"Maladisant", 101017001)
	end
end

function setup2D_S_Maladisant_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Maladisant2,"Maladisant2", 101017002)
	else	--制服
		character2DFull_Preload(Maladisant,"Maladisant", 101017001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Perez(style)
	if style == 2 then	--バルバロイ化
		Perez2 = set_chara_unknown()
		character2DFull(Perez2,"Perez2", 101056002)
	else	--通常
		Perez = set_chara_unknown()
		character2DFull(Perez,"Perez", 101056001)
	end
end

function setup2D_S_Perez_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--バルバロイ化
		character2DFull_Preload(Perez2,"Perez2", 101056002)
	else	--通常
		character2DFull_Preload(Perez,"Perez", 101056001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Kay(style)
	Kay = set_chara_unknown()
	character2DFull(Kay,"Kay", 101040001)
end

function setup2D_S_Kay_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Kay,"Kay", 101040001)
end

-------------------------------------------------------------------------------

function setup2D_S_Mordred(style)
	Mordred = set_chara_unknown()
	character2DFull(Mordred,"Mordred", 101022001)
end

function setup2D_S_Mordred_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Mordred,"Mordred", 101022001)
end

-------------------------------------------------------------------------------

function setup2D_S_Clarice(style)
	if style == 2 then	--キラーズ体
		Clarice2 = set_chara_unknown()
		character2DFull(Clarice2,"Clarice2", 101023002)
	else	--制服
		Clarice = set_chara_unknown()
		character2DFull(Clarice,"Clarice", 101023001)
	end
end

function setup2D_S_Clarice_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Clarice2,"Clarice2", 101023002)
	else	--制服
		character2DFull_Preload(Clarice,"Clarice", 101023001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Bors(style)
	Bors = set_chara_unknown()
	character2DFull(Bors,"Bors", 101024001)
end

function setup2D_S_Bors_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Bors,"Bors", 101024001)
end

-------------------------------------------------------------------------------

function setup2D_S_Clare(style)
	if style == 2 then	--キラーズ体
		Clare2 = set_chara_unknown()
		character2DFull(Clare2,"Clare2", 101025002)
	else	--制服
		Clare = set_chara_unknown()
		character2DFull(Clare,"Clare", 101025001)
	end
end

function setup2D_S_Clare_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Clare2,"Clare2", 101025002)
	else	--制服
		character2DFull_Preload(Clare,"Clare", 101025001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Liliana(style)
	if style == 2 then	--キラーズ体
		Liliana2 = set_chara_unknown()
		character2DFull(Liliana2,"Liliana2", 101035002)
	else	--制服
		Liliana = set_chara_unknown()
		character2DFull(Liliana,"Liliana", 101035001)
	end
end

function setup2D_S_Liliana_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Liliana2,"Liliana2", 101035002)
	else	--制服
		character2DFull_Preload(Liliana,"Liliana", 101035001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Excelia(style)
	if style == 2 then	--キラーズ体
		Excelia2 = set_chara_unknown()
		character2DFull(Excelia2,"Excelia2", 101034002)
	else	--制服
		Excelia = set_chara_unknown()
		character2DFull(Excelia,"Excelia", 101034001)
	end
end

function setup2D_S_Excelia_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Excelia2,"Excelia2", 101034002)
	else	--制服
		character2DFull_Preload(Excelia,"Excelia", 101034001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Christina(style)
	Christina = set_chara_unknown()
	character2DFull(Christina,"Christina", 101063001)
end

function setup2D_S_Christina_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Christina,"Christina", 101063001)
end

-------------------------------------------------------------------------------

function setup2D_S_Tristan(style)
	Tristan = set_chara_unknown()
	character2DFull(Tristan,"Tristan", 101014001)
end

function setup2D_S_Tristan_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Tristan,"Tristan", 101014001)
end

-------------------------------------------------------------------------------

function setup2D_S_Isolde(style)
	if style == 2 then	--キラーズ体
		Isolde2 = set_chara_unknown()
		character2DFull(Isolde2,"Isolde2", 101019002)
	else	--制服
		Isolde = set_chara_unknown()
		character2DFull(Isolde,"Isolde", 101019001)
	end
end

function setup2D_S_Isolde_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Isolde2,"Isolde2", 101019002)
	else	--制服
		character2DFull_Preload(Isolde,"Isolde", 101019001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Laevatein(style)
	if style == 2 then	--キラーズ体
		Laevatein2 = set_chara_unknown()
		character2DFull(Laevatein2,"Laevatein2", 101002002)
	else	--制服
		Laevatein = set_chara_unknown()
		character2DFull(Laevatein,"Laevatein", 101002001)
	end
end

function setup2D_S_Laevatein_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Laevatein2,"Laevatein2", 101002002)
	else	--制服
		character2DFull_Preload(Laevatein,"Laevatein", 101002001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Freikugel(style)
	if style == 2 then	--キラーズ体
		Freikugel2 = set_chara_unknown()
		character2DFull(Freikugel2,"Freikugel2", 101070002)
	else	--制服
		Freikugel = set_chara_unknown()
		character2DFull(Freikugel,"Freikugel", 101070001)
	end
end

function setup2D_S_Freikugel_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then	--キラーズ体
		character2DFull_Preload(Freikugel2,"Freikugel2", 101070002)
	else	--制服
		character2DFull_Preload(Freikugel,"Freikugel", 101070001)
	end
end

-------------------------------------------------------------------------------

function setup2D_S_Alham(style)
	Alham = set_chara_unknown()
	character2DFull(Alham,"Alham", 101059001)
end

function setup2D_S_Alham_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Alham,"Alham", 101059001)
end

-------------------------------------------------------------------------------

function setup2D_S_Mathajim(style)
	Mathajim = set_chara_unknown()
	character2DFull(Mathajim,"Mathajim", 101053001)
end

function setup2D_S_Mathajim_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Mathajim,"Mathajim", 101053001)
end

-------------------------------------------------------------------------------

function setup2D_S_Adam(style)
	Adam = set_chara_unknown()
	character2DFull(Adam,"Adam", 101054001)
end

function setup2D_S_Adam_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Adam,"Adam", 101054001)
end

-------------------------------------------------------------------------------

function setup2D_S_Owen(style)
	Owen = set_chara_unknown()
	character2DFull(Owen,"Owen", 101055001)
end

function setup2D_S_Owen_preload(style)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Owen,"Owen", 101055001)
end

-------------------------------------------------------------------------------
