--[[
	主に疑似バトルADVやバトルADV系のデモで使用するドット関連に対応した関数を記入する
]]

Include("content_luascript_common", "SoundCommonPack")

-- ---------------------------------------------------------------------------------------------------------------------
-- 以下は疑似バトルフィールドADV
-- ---------------------------------------------------------------------------------------------------------------------

-- ---------------------------------
-- 事前準備用関数
-- ---------------------------------
--style スタイルID
--usedot ドットモデルも準備するか ture false
--xpos マップのX座標
--ypos マップのY座標

-- ティルフィング準備
function pbadv_setup_101001_Tyrfing(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Tyrfing1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Tyrfing1, "Tyrfing1", 101001002) 

	elseif style == 2 then  --制服歩兵
		Tyrfing2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Tyrfing2, "Tyrfing2", 101001001)
		
	else
		Tyrfing = set_chara_unknown()
		character2DFull(Tyrfing, "Tyrfing", 101001001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotTyrfing1 = dot_reserve_ally(101001002, xpos, ypos, layer) 	 --ティルフィング・ドット準備
			dot_set_weapon(dotTyrfing1, 101010001)	--ティルフィング・武器準備   剣

		elseif style == 2 then  --制服歩兵
			dotTyrfing2 = dot_reserve_ally(101001003, xpos, ypos, layer) 	 --ティルフィング・ドット準備
			dot_set_weapon(dotTyrfing2, 107010001)	--ティルフィング・武器準備  書
		
		else
			dotTyrfing = dot_reserve_ally(101001001, xpos, ypos, layer) 	 --ティルフィング・ドット準備
			dot_set_weapon(dotTyrfing, 107010001)	--ティルフィング・武器準備  書
		
		end	
		
	end
	
end	


-- ノワール準備	
function pbadv_setup_101009_Noir(style,usedot,xpos,ypos,layer)
	
	-- style 1:雨具 ※未使用
	-- style 2:金コート版
	-- style 3:東方諸国連合軍
	-- style 4:幼少期　※3Dモデル無し
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える
	if style == 2 then   --金コート版
		Noir2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Noir2, "Noir2", 101009001) 
		
	elseif style == 3 then  --東方諸国連合軍
		Noir3 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Noir3, "Noir3", 101009003)
		
	elseif style == 4 then  --幼少期
		Noir4 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Noir4, "Noir4", 101009005)
		
	else  --制服のみ
		Noir = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Noir, "Noir", 101009002)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
		
		if style == 2 then --金コート版
			dotNoir2 = dot_reserve_ally(101009001, xpos, ypos, layer) 	 --ノワール・ドット準備
			dot_set_weapon(dotNoir2, 101010001)	--ノワール・武器準備  剣
			
		elseif style == 3 then  --東方諸国連合軍
			dotNoir3 = dot_reserve_ally(101009003, xpos, ypos, layer) 	 --ノワール・ドット準備
			dot_set_weapon(dotNoir3, 101010001)	--ノワール・武器準備  剣
			
		elseif style == 4 then
		
		else  --制服のみ
			dotNoir = dot_reserve_ally(101009001, xpos, ypos, layer) 	 --ノワール・ドット準備
			dot_set_weapon(dotNoir, 101010001)	--ノワール・武器準備  剣
		end	
		
	end
	
end	

-- ランスロット準備	
function pbadv_setup_101010_Lancelot(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style 2:幼少期　※3Dモデル無し
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える
	if style == 1 then   --キラーズ
		Lancelot1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Lancelot1, "Lancelot1", 101010002) 
		
	elseif style == 2 then  --幼少期
		Lancelot2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Lancelot2, "Lancelot2", 101010003)
		
	elseif style == 3 then  --歩兵
		Lancelot3 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Lancelot3, "Lancelot3", 101010001)
		
	else  -- style 通常
		Lancelot = set_chara_unknown()
		character2DFull(Lancelot, "Lancelot", 101010001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotLancelot1 = dot_reserve_ally(101010002, xpos, ypos, layer) 	 --ランスロット・ドット準備
			dot_set_weapon(dotLancelot1, 101010001)	--ランスロット・武器準備  剣
			
		elseif style == 2 then  --幼少期
	
		elseif style == 3 then  --歩兵
			dotLancelot3 = dot_reserve_ally(101010004, xpos, ypos, layer) 	 --ランスロット・ドット準備
			dot_set_weapon(dotLancelot3, 101010001)	--ランスロット・武器準備  剣

		else  -- style 通常
			dotLancelot = dot_reserve_ally(101010001, xpos, ypos, layer) 	 --ランスロット・ドット準備
			dot_set_weapon(dotLancelot, 101010001)	--ランスロット・武器準備  剣
		end	
		
	end
	
end	

-- ギネヴィア準備	
function pbadv_setup_101011_Guinevere(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style 2:ドレス
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える
	if style == 1 then   --キラーズ
		Guinevere1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Guinevere1, "Guinevere1", 101011002) 
		
	elseif style == 2 then  --ドレス
		Guinevere2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Guinevere2, "Guinevere2", 101011003)
		
	else
		Guinevere = set_chara_unknown()
		character2DFull(Guinevere, "Guinevere", 101011001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	debug_print("ギネヴィア")
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotGuinevere1 = dot_reserve_ally(101011002, xpos, ypos, layer) 	 --ギネヴィア・ドット準備
			dot_set_weapon(dotGuinevere1, 101010001)	--ギネヴィア・武器準備  剣
			
		elseif style == 2 then  --ドレス
		
		else
			dotGuinevere = dot_reserve_ally(101011001, xpos, ypos, layer) 	 --ギネヴィア・ドット準備
			dot_set_weapon(dotGuinevere, 104010001)	--ギネヴィア・武器準備  直槍
		end	
		
	end
	
end	


-- ディナタン準備	
function pbadv_setup_101012_Dinatan(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style 2:傭兵
	-- style 3:幼少期　※3Dモデル無し
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える
	if style == 1 then   --キラーズ
		Dinatan1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Dinatan1, "Dinatan1", 101012002)
		
	elseif style == 2 then  --傭兵
		Dinatan2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Dinatan2, "Dinatan2", 101012003)
		
	elseif style == 3 then  --幼少期
		Dinatan3 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Dinatan3, "Dinatan3", 101012004)
		
	else
		Dinatan = set_chara_unknown()
		character2DFull(Dinatan, "Dinatan", 101012001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotDinatan1 = dot_reserve_ally(101012002, xpos, ypos, layer) 	 --ディナタン・ドット準備
			dot_set_weapon(dotDinatan1, 101010001)	--ディナタン・武器準備  剣
			
		elseif style == 2 then  --傭兵
			dotDinatan2 = dot_reserve_ally(101012003, xpos, ypos, layer) 	 --ディナタン・ドット準備
			dot_set_weapon(dotDinatan2, 108010001)	--ディナタン・武器準備  杖
					
		elseif style == 3 then  --幼少期

		else
			dotDinatan = dot_reserve_ally(101012001, xpos, ypos, layer) 	--ディナタン・ドット準備
			dot_set_weapon(dotDinatan, 108010001)	--ディナタン・武器準備  杖
			
		end	
		
	end
	
end	


-- ガウェイン準備
function pbadv_setup_101013_Gawain(style,usedot,xpos,ypos,layer)

	-- style 1:敵対差分
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --敵対差分
		Gawain1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Gawain1, "Gawain1", 101013002) 
		
	else
		Gawain = set_chara_unknown()
		character2DFull(Gawain, "Gawain", 101013001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then   --敵対差分(ドット差分はない）
			dotGawain1 = dot_reserve_ally(101013001, xpos, ypos, layer) 	 --ガウェイン・ドット準備
			dot_set_weapon(dotGawain1, 103010001)	--ガウェイン・武器準備 大槌
			
		else
			dotGawain = dot_reserve_ally(101013001, xpos, ypos, layer) 	 --ガウェイン・ドット準備
			dot_set_weapon(dotGawain, 103010001)	--ガウェイン・武器準備 大槌
		
		end	
		
	end
	
end	


-- トリスタン準備
function pbadv_setup_101014_Tristan(style,usedot,xpos,ypos,layer)

	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --通常
		Tristan = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Tristan, "Tristan", 101014001) 
		
	else
		Tristan = set_chara_unknown()
		character2DFull(Tristan, "Tristan", 101014001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --
			dotTristan = dot_reserve_ally(101014001, xpos, ypos, layer) 	 --トリスタン・ドット準備
			dot_set_weapon(dotTristan, 105010001)	--トリスタン・武器準備 長弓
		
		else
			dotTristan = dot_reserve_ally(101014001, xpos, ypos, layer) 	 --トリスタン・ドット準備
			dot_set_weapon(dotTristan, 105010001)	--トリスタン・武器準備 長弓
		
		end	
		
	end
	
end	


-- アーサー準備
function pbadv_setup_101015_Arthur(style,usedot,xpos,ypos,layer)
	
	-- style 1:バルバロイ
	-- style 2:敵対差分
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --通常
		Arthur1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Arthur1, "Arthur1", 101015002)
		
	elseif style == 2 then   --敵対差分
		Arthur2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Arthur2, "Arthur2", 101015003)
		
	else
		Arthur = set_chara_unknown()
		character2DFull(Arthur, "Arthur", 101015001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --バルバロイ
			--debug_print("敵ID実装時に入れ替え予定")
			dotArthur1 = dot_reserve_ally(101015002, xpos, ypos, layer) 	 --アーサー・ドット準備
			dot_set_weapon(dotArthur1, 101010001)	--アーサー・武器準備 片手剣
		
		elseif style == 2 then  --敵対差分(ドット差分はない）
			dotArthur2 = dot_reserve_ally(101015001, xpos, ypos, layer) 	 --アーサー・ドット準備
			dot_set_weapon(dotArthur2, 101010001)	--アーサー・武器準備  片手剣
		
		else
			dotArthur = dot_reserve_ally(101015001, xpos, ypos, layer) 	 --アーサー・ドット準備
			dot_set_weapon(dotArthur, 101010001)	--アーサー・武器準備  片手剣
		
		end	
		
	end
	
end	


-- ギネマウア準備
function pbadv_setup_101016_Gwenhwymawr(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --通常
		Gwenhwymawr1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Gwenhwymawr1, "Gwenhwymawr1", 101016002) 
		
	else
		Gwenhwymawr = set_chara_unknown()
		character2DFull(Gwenhwymawr, "Gwenhwymawr", 101016001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotGwenhwymawr1 = dot_reserve_ally(101016002, xpos, ypos, layer) 	 --ギネマウア・ドット準備
			dot_set_weapon(dotGwenhwymawr1, 104020001)	--ギネマウア・武器準備 やり
		
		else
			dotGwenhwymawr = dot_reserve_ally(101016001, xpos, ypos, layer) 	 --ギネマウア・ドット準備
			dot_set_weapon(dotGwenhwymawr, 108010001)	--ギネマウア・武器準備  杖
		
		end	
		
	end
	
end	


-- マルディサント準備	
function pbadv_setup_101017_Maladisant(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style 2:療養服
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える
	if style == 1 then   --キラーズ
		Maladisant1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Maladisant1, "Maladisant1", 101017002) 
		
	elseif style == 2 then  --療養服
		Maladisant2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Maladisant2, "Maladisant2", 101017003)
		
	else  -- style 通常
		Maladisant = set_chara_unknown()
		character2DFull(Maladisant, "Maladisant", 101017001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotMaladisant1 = dot_reserve_ally(101017002, xpos, ypos, layer) 	 --マルディサント・ドット準備
			dot_set_weapon(dotMaladisant1, 102020001)	--マルディサント・武器準備 大斧
			
		elseif style == 2 then  --療養服
		
		else  -- style 通常
			dotMaladisant = dot_reserve_ally(101017001, xpos, ypos, layer) 	 --マルディサント・ドット準備
			dot_set_weapon(dotMaladisant, 103010001)	--マルディサント・武器準備  大槌
		end	
		
	end
	
end	


-- ラグネル準備	
function pbadv_setup_101018_Ragnar(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える
	if style == 1 then   --キラーズ
		Ragnar1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Ragnar1, "Ragnar1", 101018002) 

	elseif style == 2 then  --キラーズ歩兵
		Ragnar2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Ragnar2, "Ragnar2", 101018002)
				
	else  -- style 通常
		Ragnar = set_chara_unknown()
		character2DFull(Ragnar, "Ragnar", 101018001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotRagnar1 = dot_reserve_ally(101018002, xpos, ypos, layer) 	 --ラグネル・ドット準備
			dot_set_weapon(dotRagnar1, 102010001)	--ラグネル・武器準備 斧

		elseif style == 2 then  --キラーズ歩兵
			dotRagnar2 = dot_reserve_ally(101018003, xpos, ypos, layer) 	 --ラグネル・ドット準備
			dot_set_weapon(dotRagnar2, 102020001)	--ラグネル・武器準備 斧
			
		else  -- style 通常
			dotRagnar = dot_reserve_ally(101018001, xpos, ypos, layer) 	 --ラグネル・ドット準備
			dot_set_weapon(dotRagnar, 106010001)	--ラグネル・武器準備  拳銃
		end	
		
	end
	
end	


-- イゾルデ準備
function pbadv_setup_101019_Isolde(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --通常
		Isolde1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Isolde1, "Isolde1", 101019002) 
		

	elseif style == 2 then   --通常
		Isolde2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Isolde2, "Isolde2", 101019002) 

	else
		Isolde = set_chara_unknown()
		character2DFull(Isolde, "Isolde", 101019001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotIsolde1 = dot_reserve_ally(101019002, xpos, ypos, layer) 	 --イゾルデ・ドット準備
			dot_set_weapon(dotIsolde1, 105010001)	--イゾルデ・武器準備 長弓

		
		elseif style == 2 then --キラーズ歩兵
			dotIsolde2 = dot_reserve_ally(101019003, xpos, ypos, layer) 	 --イゾルデ・ドット準備
			dot_set_weapon(dotIsolde2, 105010001)	--イゾルデ・武器準備 長弓


		else
			dotIsolde = dot_reserve_ally(101019001, xpos, ypos, layer) 	 --イゾルデ・ドット準備
			dot_set_weapon(dotIsolde, 107010001)	--イゾルデ・武器準備  書
		
		end	
		
	end
	
end	


-- マーリン準備
function pbadv_setup_101020_Merlin(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Merlin1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Merlin1, "Merlin1", 101020002) 

	elseif style == 2 then   --魔術師歩兵
		Merlin2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Merlin2, "Merlin2", 101020001) 
		
	else 
		Merlin = set_chara_unknown()
		character2DFull(Merlin, "Merlin", 101020001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotMerlin1 = dot_reserve_ally(101020002, xpos, ypos, layer) 	 --マーリン・ドット準備
			dot_set_weapon(dotMerlin1, 101010001)	--マーリン・武器準備  剣
		
		elseif style == 2 then --魔術師歩兵
			dotMerlin2 = dot_reserve_ally(101020003, xpos, ypos, layer) 	 --マーリン・ドット準備
			dot_set_weapon(dotMerlin2, 107010001)	--マーリン・武器準備  書

		else
			dotMerlin = dot_reserve_ally(101020001, xpos, ypos, layer) 	 --マーリン・ドット準備
			dot_set_weapon(dotMerlin, 107010001)	--マーリン・武器準備  書
		
		end	
		
	end
	
end	


-- ブルーノ準備
function pbadv_setup_101021_Bruno(style,usedot,xpos,ypos,layer)

	-- style  1: 仮面無し
	-- style  2: 傭兵
	-- style  3: 歩兵
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --仮面無
		Bruno1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Bruno1, "Bruno1", 101021002) 
	
	elseif style == 2 then   --傭兵
		Bruno2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Bruno2, "Bruno2", 101021003) 
			
	elseif style == 3 then   --歩兵
		Bruno3 = set_chara_unknown()--３Dモデル使わない宣言　顔絵は一旦通常
		character2DFull(Bruno3, "Bruno3", 101021001) 
			
	else --通常
		Bruno = set_chara_unknown()
		character2DFull(Bruno, "Bruno", 101021001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --仮面無 101021002
			dotBruno1 = dot_reserve_ally(101021002, xpos, ypos, layer) 	 --ブルーノ・ドット準備
			dot_set_weapon(dotBruno1, 101010001)	--ブルーノ・武器準備 片手剣
			
			
		elseif style == 2 then   --傭兵 101021003
			dotBruno2 = dot_reserve_ally(101021003, xpos, ypos, layer) 	 --ブルーノ・ドット準備 
			dot_set_weapon(dotBruno2, 101010001)	--ブルーノ・武器準備 片手剣
			
		
		elseif style == 3 then   --歩兵 101021004
			dotBruno3 = dot_reserve_ally(101021004, xpos, ypos, layer) 	 --ブルーノ歩兵・ドット準備
			dot_set_weapon(dotBruno3, 101010001)	--ブルーノ・武器準備 片手剣
			
		
		else
			dotBruno = dot_reserve_ally(101021001, xpos, ypos, layer) 	 --ブルーノ・ドット準備
			dot_set_weapon(dotBruno, 101010001)	--ブルーノ・武器準備 片手剣
		
		end	
		
	end
	
end	


-- モルドレッド準備
function pbadv_setup_101022_Mordred(style,usedot,xpos,ypos,layer)

	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --通常
		Mordred = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Mordred, "Mordred", 101022001) 
		
	else
		Mordred = set_chara_unknown()
		character2DFull(Mordred, "Mordred", 101022001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --
			dotMordred = dot_reserve_ally(101022001, xpos, ypos, layer) 	 --モルドレッド・ドット準備
			dot_set_weapon(dotMordred, 101030001)	--モルドレッド・武器準備 大剣
		
		else
			dotMordred = dot_reserve_ally(101022001, xpos, ypos, layer) 	 --モルドレッド・ドット準備
			dot_set_weapon(dotMordred, 101030001)	--モルドレッド・武器準備 大剣
		
		end	
		
	end
	
end	


-- クラリス準備
function pbadv_setup_101023_Clarice(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Clarice1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Clarice1, "Clarice1", 101023002) 
		
	else 
		Clarice = set_chara_unknown()
		character2DFull(Clarice, "Clarice", 101023001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotClarice1 = dot_reserve_ally(101023002, xpos, ypos, layer) 	 --クラリス・ドット準備
			dot_set_weapon(dotClarice1, 101010001)	--クラリス・武器準備  剣
		
		else
			dotClarice = dot_reserve_ally(101023001, xpos, ypos, layer) 	 --クラリス・ドット準備
			dot_set_weapon(dotClarice, 107010001)	--クラリス・武器準備  書
		
		end	
		
	end
	
end	


-- ヴォールス準備
function pbadv_setup_101024_Bors(style,usedot,xpos,ypos,layer)

	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --通常
		Bors = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Bors, "Bors", 101024001) 
		
	else
		Bors = set_chara_unknown()
		character2DFull(Bors, "Bors", 101024001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --
			dotBors = dot_reserve_ally(101024001, xpos, ypos, layer) 	 --トリスタン・ドット準備
			dot_set_weapon(dotBors, 102020001)	--ヴォールス・武器準備 長弓
		
		else
			dotBors = dot_reserve_ally(101024001, xpos, ypos, layer) 	 --トリスタン・ドット準備
			dot_set_weapon(dotBors, 102020001)	--ヴォールス・武器準備 長弓
		
		end
		
	end
	
end


-- クレア準備
function pbadv_setup_101025_Clare(style,usedot,xpos,ypos,layer)

	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --通常
		Clare1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Clare1, "Clare1", 101025002) 
		
	else
		Clare = set_chara_unknown()
		character2DFull(Clare, "Clare", 101025001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --
			dotClare1 = dot_reserve_ally(101025002, xpos, ypos, layer) 	 --クレア・ドット準備
			dot_set_weapon(dotClare1, 104010001)	--クレア・武器準備 やり
		
		else
			dotClare = dot_reserve_ally(101025001, xpos, ypos, layer) 	 --クレア・ドット準備
			dot_set_weapon(dotClare, 108010001)	--クレア・武器準備 杖
		
		end	
		
	end
	
end


-- パーシヴァル準備
function pbadv_setup_101026_Percival(style,usedot,xpos,ypos,layer)

	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then
		Percival = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Percival, "Percival", 101026001) 
		
	else
		Percival = set_chara_unknown()
		character2DFull(Percival, "Percival", 101026001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotPercival = dot_reserve_ally(101026001, xpos, ypos, layer) 	 --パーシヴァル・ドット準備
			dot_set_weapon(dotPercival, 101020001)	--パーシヴァル・武器準備
		
		else
			dotPercival = dot_reserve_ally(101026001, xpos, ypos, layer) 	 --パーシヴァル・ドット準備
			dot_set_weapon(dotPercival, 101020001)	--パーシヴァル・武器準備
		
		end	
		
	end
	
end	


-- ディンドラン準備
function pbadv_setup_101027_Dindrane(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Dindrane1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Dindrane1, "Dindrane1", 101027002) 
		
	elseif style == 2 then   --キラーズ歩兵
		Dindrane2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Dindrane2, "Dindrane2", 101027002) 
		
	else
		Dindrane = set_chara_unknown()
		character2DFull(Dindrane, "Dindrane", 101027001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotDindrane1 = dot_reserve_ally(101027002, xpos, ypos, layer) 	 --ディンドラン・ドット準備
			dot_set_weapon(dotDindrane1, 104020001)	--ディンドラン・武器準備  やり
		
		elseif style == 2 then --キラーズ
			dotDindrane2 = dot_reserve_ally(101027003, xpos, ypos, layer) 	 --ディンドラン・ドット準備
			dot_set_weapon(dotDindrane2, 104020001)	--ディンドラン・武器準備  やり

		else
			dotDindrane = dot_reserve_ally(101027001, xpos, ypos, layer) 	 --ディンドラン・ドット準備
			dot_set_weapon(dotDindrane, 106010001)	--ディンドラン・武器準備  短剣
		
		end	
		
	end
	
end	


-- ガラハッド準備	
function pbadv_setup_101028_Galahad(style,usedot,xpos,ypos,layer)
	
	-- style 1:銀卓の騎士
	-- style 2:兜有
	-- style 3:暴走
	-- style それ以外:制服
	
	--スタイルに合わせてキャラ２D絵を変える
	if style == 1 then   --銀卓の騎士
		Galahad1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Galahad1, "Galahad1", 101028002)
		
	elseif style == 2 then  --兜有
		Galahad2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Galahad2, "Galahad2", 101028003)
		
	elseif style == 3 then  --暴走
		Galahad3 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Galahad3, "Galahad3", 101028004)
		
	else  -- style 制服
		Galahad = set_chara_unknown()
		character2DFull(Galahad, "Galahad", 101028001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --銀卓の騎士
			dotGalahad1 = dot_reserve_ally(101028002, xpos, ypos, layer) 	 --ガラハッド・ドット準備
			dot_set_weapon(dotGalahad1, 101010001)	--ガラハッド・武器準備  剣
			
		elseif style == 2 then  --兜有
			dotGalahad2 = dot_reserve_ally(101028003, xpos, ypos, layer) 	 --ガラハッド・ドット準備
			dot_set_weapon(dotGalahad2, 101010001)	--ガラハッド・武器準備  剣
					
		elseif style == 3 then  --暴走
			--一旦味方で登録
			dotGalahad3 = dot_reserve_ally(101028004, xpos, ypos, layer) 	 --ガラハッド・ドット準備
			dot_set_weapon(dotGalahad3, 101010001)	--ガラハッド・武器準備  剣

		else  -- style 制服
			dotGalahad = dot_reserve_ally(101028001, xpos, ypos, layer) 	 --ガラハッド・ドット準備
			dot_set_weapon(dotGalahad, 105010001)	--ガラハッド・武器準備 剣
			
		end	
		
	end
	
end


-- アステラ準備
function pbadv_setup_101029_Astera(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Astera1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Astera1, "Astera1", 101029002) 
		
	else 
		Astera = set_chara_unknown()
		character2DFull(Astera, "Astera", 101029001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotAstera1 = dot_reserve_ally(101029002, xpos, ypos, layer) 	 --アステラ・ドット準備
			dot_set_weapon(dotAstera1, 101030001)	--アステラ・武器準備  大剣
		
		else
			dotAstera = dot_reserve_ally(101029001, xpos, ypos, layer) 	 --アステラ・ドット準備
			dot_set_weapon(dotAstera, 105010001)	--アステラ・武器準備  弓
		
		end	
		
	end
	
end	


-- エレイン準備
function pbadv_setup_101030_Elaine(style,usedot,xpos,ypos,layer)
	
	-- style 1:顔傷有
	-- style 2:ドレス姿
	-- style それ以外:制服
	
	--スタイルに合わせてキャラ２D絵を変える
	if style == 1 then   --顔傷有
		Elaine1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Elaine1, "Elaine1", 101030002)
		
	elseif style == 2 then  --ドレス
		Elaine2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Elaine2, "Elaine2", 101030003)

	elseif style == 3 then  --制服歩兵
		Elaine3 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Elaine3, "Elaine3", 101030001)
		
	else  -- style 制服
		Elaine = set_chara_unknown()
		character2DFull(Elaine, "Elaine", 101030001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --顔傷有
			dotElaine1 = dot_reserve_ally(101030002, xpos, ypos, layer) 	 --エレイン・ドット準備
			dot_set_weapon(dotElaine1, 104010001)	--エレイン・武器準備  直槍
			
		elseif style == 2 then  --ドレス

		elseif style == 3 then  --制服歩兵
			dotElaine3 = dot_reserve_ally(101030004, xpos, ypos, layer) 	 --エレイン・ドット準備
			dot_set_weapon(dotElaine3, 104010001)	--エレイン・武器準備  直槍

		else  -- style 制服
			dotElaine = dot_reserve_ally(101030001, xpos, ypos, layer) 	 --エレイン・ドット準備
			dot_set_weapon(dotElaine, 104010001)	--エレイン・武器準備  直槍
			
		end	
		
	end
	
end


-- ラヴェイン準備
function pbadv_setup_101031_Lovein(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Lovein1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Lovein1, "Lovein1", 101031002) 
		
	else
		Lovein = set_chara_unknown()
		character2DFull(Lovein, "Lovein", 101031001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotLovein1 = dot_reserve_ally(101031002, xpos, ypos, layer) 	 --ラヴェイン・ドット準備
			dot_set_weapon(dotLovein1, 104010001)	--ラヴェイン・武器準備  直槍
		
		else
			dotLovein = dot_reserve_ally(101031001, xpos, ypos, layer) 	 --ラヴェイン・ドット準備
			dot_set_weapon(dotLovein, 103010001)	--ラヴェイン・武器準備  大槌
		
		end	
		
	end
	
end	


-- ガレス準備
function pbadv_setup_101032_Gareth(style,usedot,xpos,ypos,layer)

	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then
		Gareth = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Gareth, "Gareth", 101032001) 
		
	else
		Gareth = set_chara_unknown()
		character2DFull(Gareth, "Gareth", 101032001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotGareth = dot_reserve_ally(101032001, xpos, ypos, layer) 	 --ガレス・ドット準備
			dot_set_weapon(dotGareth, 103010001)	--ガレス・武器準備　大槌
		
		else
			dotGareth = dot_reserve_ally(101032001, xpos, ypos, layer) 	 --ガレス・ドット準備
			dot_set_weapon(dotGareth, 103010001)	--ガレス・武器準備　大槌
		
		end	
		
	end
	
end	


-- リオネス準備
function pbadv_setup_101033_Lyoness(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Lyoness1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Lyoness1, "Lyoness1", 101033002) 
		
	else 
		Lyoness = set_chara_unknown()
		character2DFull(Lyoness, "Lyoness", 101033001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotLyoness1 = dot_reserve_ally(101033002, xpos, ypos, layer) 	 --リオネス・ドット準備
			dot_set_weapon(dotLyoness1, 106020001)	--リオネス・武器準備  狙撃銃
		
		else
			dotLyoness = dot_reserve_ally(101033001, xpos, ypos, layer) 	 --リオネス・ドット準備
			dot_set_weapon(dotLyoness, 108010001)	--リオネス・武器準備  回復杖
		
		end	
		
	end
	
end	


-- エクセリア準備
function pbadv_setup_101034_Excelia(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Excelia1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Excelia1, "Excelia1", 101034002) 
		
	else
		Excelia = set_chara_unknown()
		character2DFull(Excelia, "Excelia", 101034001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotExcelia1 = dot_reserve_ally(101034002, xpos, ypos, layer) 	 --エクセリア・ドット準備
			dot_set_weapon(dotExcelia1, 107010001)	--エクセリア・武器準備    書
		
		else
			dotExcelia = dot_reserve_ally(101034001, xpos, ypos, layer) 	 --エクセリア・ドット準備
			dot_set_weapon(dotExcelia, 106020001)	--エクセリア・武器準備  狙撃
		
		end	
		
	end
	
end	


-- リリアーナ準備
function pbadv_setup_101035_Liliana(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Liliana1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Liliana1, "Liliana1", 101035002) 
		
	else
		Liliana = set_chara_unknown()
		character2DFull(Liliana, "Liliana", 101035001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotLiliana1 = dot_reserve_ally(101035002, xpos, ypos, layer) 	 --リリアーナ・ドット準備
			dot_set_weapon(dotLiliana1, 104010001)	--リリアーナ・武器準備    やり
		
		else
			dotLiliana = dot_reserve_ally(101035001, xpos, ypos, layer) 	 --リリアーナ・ドット準備
			dot_set_weapon(dotLiliana, 108010001)	--リリアーナ・武器準備  杖
		
		end	
		
	end
	
end	


-- フィエナ準備
function pbadv_setup_101036_Viena(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Viena1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Viena1, "Viena1", 101036002) 
		
	else
		Viena = set_chara_unknown()
		character2DFull(Viena, "Viena", 101036001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotViena1 = dot_reserve_ally(101036002, xpos, ypos, layer) 	 --フィエナ・ドット準備
			dot_set_weapon(dotViena1, 108010001)	--フィエナ・武器準備  杖
		
		else
			dotViena = dot_reserve_ally(101036001, xpos, ypos, layer) 	 --フィエナ・ドット準備
			dot_set_weapon(dotViena, 105010001)	--フィエナ・武器準備 長弓
		
		end	
		
	end
	
end	


-- ラシア準備
function pbadv_setup_101037_Rasia(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Rasia1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Rasia1, "Rasia1", 101037002) 
		
	elseif style == 2 then   --キラーズ歩兵
		Rasia2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Rasia2, "Rasia2", 101037002) 
		
	elseif style == 3 then   --キラーズ歩兵
		Rasia3 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Rasia3, "Rasia3", 101037001) 

	else 
		Rasia = set_chara_unknown()
		character2DFull(Rasia, "Rasia", 101037001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotRasia1 = dot_reserve_ally(101037002, xpos, ypos, layer) 	 --ラシア・ドット準備
			dot_set_weapon(dotRasia1, 101010001)	--ラシア・武器準備  剣
		
		elseif style == 2 then --キラーズ歩兵
			dotRasia2 = dot_reserve_ally(101037003, xpos, ypos, layer) 	 --ラシア・ドット準備
			dot_set_weapon(dotRasia2, 101010001)	--ラシア・武器準備  剣

		elseif style == 3 then --制服歩兵
			dotRasia3 = dot_reserve_ally(101037004, xpos, ypos, layer) 	 --ラシア・ドット準備
			dot_set_weapon(dotRasia3, 107010001)	--ラシア・武器準備  書

		else
			dotRasia = dot_reserve_ally(101037001, xpos, ypos, layer) 	 --ラシア・ドット準備
			dot_set_weapon(dotRasia, 107010001)	--ラシア・武器準備  書
		
		end	
		
	end
	
end


-- ローラ準備
function pbadv_setup_101038_Lola(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style 2:キラーズ（バルバロイ）
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Lola1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Lola1, "Lola1", 101038002) 
		
	elseif style == 2 then --キラーズ（バルバロイ）
		Lola2 = set_chara_unknown()
		character2DFull(Lola2, "Lola2", 101038003)

	else 
		Lola = set_chara_unknown()
		character2DFull(Lola, "Lola", 101038001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotLola1 = dot_reserve_ally(101038002, xpos, ypos, layer) 	 --ローラ・ドット準備
			dot_set_weapon(dotLola1, 101030001)	--ローラ・武器準備  剣
		
		elseif style == 2 then --キラーズ（バルバロイ）
			dotLola2 = dot_reserve_ally(101038002, xpos, ypos, layer) 	 --ローラ・ドット準備
			dot_set_weapon(dotLola2, 101030001)	--ローラ・武器準備  剣
			
		else
			dotLola = dot_reserve_ally(101038001, xpos, ypos, layer) 	 --ローラ・ドット準備
			dot_set_weapon(dotLola, 103010001)	--ローラ・武器準備  大槌
		
		end	
		
	end
	
end	


-- フレン準備
function pbadv_setup_101039_Fren(style,usedot,xpos,ypos,layer)
	
	-- style 1:キラーズ
	-- style 2:キラーズ（バルバロイ）
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --キラーズ
		Fren1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Fren1, "Fren1", 101039002) 
		
	elseif style == 2 then --キラーズ（バルバロイ）
		Fren2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Fren2, "Fren2", 101039003) 

	else 
		Fren = set_chara_unknown()
		character2DFull(Fren, "Fren", 101039001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotFren1 = dot_reserve_ally(101039002, xpos, ypos, layer) 	 --フレン・ドット準備
			dot_set_weapon(dotFren1, 101010001)	--フレン・武器準備  剣
		
		elseif style == 2 then --キラーズ（バルバロイ）
			dotFren2 = dot_reserve_ally(101039002, xpos, ypos, layer) 	 --フレン・ドット準備
			dot_set_weapon(dotFren2, 101010001)	--フレン・武器準備  剣
		
		else
			dotFren = dot_reserve_ally(101039001, xpos, ypos, layer) 	 --フレン・ドット準備
			dot_set_weapon(dotFren, 102010001)	--フレン・武器準備  片手斧
		
		end	
		
	end
	
end	


-- モルガン準備
function pbadv_setup_101041_Morgan(style,usedot,xpos,ypos,layer)
	
	-- style 1:魔女
	-- style 2:車いす
	-- style 3:瀕死
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --魔女
		Morgan1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Morgan1, "Morgan1", 101041002) 
		
	elseif style == 2 then   --魔女 車いす
		Morgan2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Morgan2, "Morgan2", 101041001) 
		
	elseif style == 3 then   --魔女 瀕死
		Morgan3 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Morgan3, "Morgan3", 101041001) 
		
	elseif style == 4 then   --魔女 気絶
		Morgan4 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Morgan4, "Morgan4", 101041001) 

	else 
		Morgan = set_chara_unknown()
		character2DFull(Morgan, "Morgan", 101041001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --魔女
			dotMorgan1 = dot_reserve_enemy(26, xpos, ypos, layer) 	 --モルガン・ドット準備
		
		elseif style == 2 then --魔女 101041003 
			 dotMorgan2 = dot_reserve_ally(101041003, xpos, ypos, layer) 	 --モルガン・ドット準備
			 dot_set_weapon(dotMorgan2, 107010001)	--モルガン・武器準備  書
		
		elseif style == 3 then --魔女 101041004 
			 dotMorgan3 = dot_reserve_ally(101041004, xpos, ypos, layer) 	 --モルガン・ドット準備
			 dot_set_weapon(dotMorgan3, 107010001)	--モルガン・武器準備  書
		
		elseif style == 4 then --魔女 101041004 
			 dotMorgan4 = dot_reserve_ally(101041005, xpos, ypos, layer) 	 --モルガン・ドット準備
			dot_set_weapon(dotMorgan4, 107010001)	--モルガン・武器準備  書
		
		else
			-- dotMorgan = dot_reserve_ally(101041001, xpos, ypos, layer) 	 --モルガン・ドット準備
			-- dot_set_weapon(dotMorgan, 107010001)	--モルガン・武器準備  書
		
		end	
		
	end
	
end	


-- モーロノエー準備
function pbadv_setup_101042_Moronoe(usedot,xpos,ypos,layer)
		
		Moronoe = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Moronoe, "Moronoe", 101042001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotMoronoe = dot_reserve_enemy(27, xpos, ypos, layer) 	 --モーロノエー・ドット準備
	end
end	


-- マゾエー準備
function pbadv_setup_101043_Mazoe(usedot,xpos,ypos,layer)
		
		Mazoe = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Mazoe, "Mazoe", 101043001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotMazoe = dot_reserve_enemy(28, xpos, ypos, layer) 	 --マゾエー・ドット準備
	end
end	


-- グリーテン準備
function pbadv_setup_101044_Gliten(usedot,xpos,ypos,layer)
		
		Gliten = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Gliten, "Gliten", 101044001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotGliten = dot_reserve_enemy(29, xpos, ypos, layer) 	 --モーロノエー・ドット準備
	end
end	


-- グリートネア準備
function pbadv_setup_101045_Glitonea(usedot,xpos,ypos,layer)
		
		Glitonea = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Glitonea, "Glitonea", 101045001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotGlitonea = dot_reserve_enemy(30, xpos, ypos, layer) 	 --マゾエー・ドット準備
	end
end	


-- グリートン準備
function pbadv_setup_101046_Gliton(usedot,xpos,ypos,layer)
		
		Gliton = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Gliton, "Gliton", 101046001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotGliton = dot_reserve_enemy(31, xpos, ypos, layer) 	 --モーロノエー・ドット準備
	end
end	


-- テューロノエー準備
function pbadv_setup_101047_Tyronoe(usedot,xpos,ypos,layer)
		
		Tyronoe = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Tyronoe, "Tyronoe", 101047001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotTyronoe = dot_reserve_enemy(32, xpos, ypos, layer) 	 --テューロノエー・ドット準備
	end
end	


-- ティーテン準備
function pbadv_setup_101048_Thiten(usedot,xpos,ypos,layer)
		
		Thiten = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Thiten, "Thiten", 101048001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotThiten = dot_reserve_enemy(33, xpos, ypos, layer) 	 --ティーテン・ドット準備
	end
end	

-- ティートン準備
function pbadv_setup_101049_Thiton(usedot,xpos,ypos,layer)
		
		Thiton = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Thiton, "Thiton", 101049001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotThiton = dot_reserve_enemy(34, xpos, ypos, layer) 	 --ティートン・ドット準備
	end
end	


-- ブライアン準備
function pbadv_setup_101050_Brian(style,usedot,xpos,ypos,layer)

	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --通常
		Brian = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Brian, "Brian", 101050001) 
		
	else
		Brian = set_chara_unknown()
		character2DFull(Brian, "Brian", 101050001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --
			dotBrian = dot_reserve_ally(101050001, xpos, ypos, layer) 	 --ブライアン・ドット準備
			dot_set_weapon(dotBrian, 102020001)	--ブライアン・武器準備 大斧
		
		else
			dotBrian = dot_reserve_ally(101050001, xpos, ypos, layer) 	 --ブライアン・ドット準備
			dot_set_weapon(dotBrian, 102020001)	--ブライアン・武器準備 大斧
		
		end	
		
	end
	
end



-- ルーシャス準備
function pbadv_setup_101051_Lucius(style,usedot,xpos,ypos,layer)
	
	-- style 1:制服（キャメロット軍）
	-- style 2:バルバロイ
	-- style それ以外:皇帝
	
	--スタイルに合わせてキャラ２D絵を変える
	if style == 1 then   --制服（キャメロット軍）
		Lucius1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Lucius1, "Lucius1", 101051002)
		
	elseif style == 2 then  --バルバロイ
		Lucius2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Lucius2, "Lucius2", 101051003)
		
	else  -- style 皇帝
		Lucius = set_chara_unknown()
		character2DFull(Lucius, "Lucius", 101051001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --制服（キャメロット軍）
			dotLucius1 = dot_reserve_ally(101051002, xpos, ypos, layer) 	 --ルーシャス・ドット準備
			dot_set_weapon(dotLucius1, 101010001)	--ルーシャス・武器準備  片手剣
			
		elseif style == 2 then  --バルバロイ
			dotLucius2 = dot_reserve_ally(101051003, xpos, ypos, layer) 	 --ルーシャス・ドット準備
			dot_set_weapon(dotLucius2, 101010001)	--ルーシャス・武器準備  片手剣

		else  -- style 皇帝
			dotLucius = dot_reserve_ally(101051001, xpos, ypos, layer) 	 --ルーシャス・ドット準備
			dot_set_weapon(dotLucius, 101010001)	--ルーシャス・武器準備  片手剣
			
		end	
		
	end
	
end


-- ヴェルナルス準備
function pbadv_setup_101052_Vernarth(style,usedot,xpos,ypos,layer)
		
	--スタイルに合わせてキャラ２D絵を変える
	if style == 1 then   --制服（キャメロット軍）
		Vernarth = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Vernarth, "Vernarth", 101052001)
		
	else
		Vernarth = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Vernarth, "Vernarth", 101052001)
		
	end
--		
		
	--ドットを使うか判定
	if usedot == true then
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --顔傷有
			-- 仮-敵IDがないため
			dotVernarth = dot_reserve_ally(101052001, xpos, ypos, layer) 	 --ヴェルナルス・ドット準備
			dot_set_weapon(dotVernarth, 101010001)	--ヴェルナルス・武器準備 片手剣
			
		else
			-- 仮-敵IDがないため
			dotVernarth = dot_reserve_ally(101052001, xpos, ypos, layer) 	 --ヴェルナルス・ドット準備
			dot_set_weapon(dotVernarth, 101010001)	--ヴェルナルス・武器準備 片手剣
		end
	end
end	


-- マターヤ準備
function pbadv_setup_101053_Mathajim(style,usedot,xpos,ypos,layer)
	
	-- style 1:バルバロイ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --バルバロイ
		Mathajim1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Mathajim1, "Mathajim1", 101053002) 
		
	elseif style == 2 then  --バルバロイ
		Mathajim2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Mathajim2, "Mathajim2", 101053002)
	
	else
		Mathajim = set_chara_unknown()
		character2DFull(Mathajim, "Mathajim", 101053001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotMathajim1 = dot_reserve_ally(101053002, xpos, ypos, layer) 	 --マターヤ・ドット準備
			dot_set_weapon(dotMathajim1, 101010001)	--マターヤ・武器準備 片手剣
		
		elseif style == 2 then  --バルバロイ（武器持ち）
			dotMathajim2 = dot_reserve_ally(101053003, xpos, ypos, layer) 	 --マターヤ・ドット準備
			dot_set_weapon(dotMathajim2, 101010001)	--マターヤ・武器準備  片手剣

		else
			dotMathajim = dot_reserve_ally(101053001, xpos, ypos, layer) 	 --マターヤ・ドット準備
			dot_set_weapon(dotMathajim, 101010001)	--マターヤ・武器準備 片手剣
		
		end	
		
	end
	
end

-- アダン準備
function pbadv_setup_101054_Adam(style,usedot,xpos,ypos,layer)
	
	-- style 1:バルバロイ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then   --バルバロイ
		Adam1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Adam1, "Adam1", 101054002) 
		
	elseif style == 2 then  --バルバロイ
		Adam2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Adam2, "Adam2", 101054002)
	
	elseif style == 3 then  --バルバロイ
		Adam3 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Adam3, "Adam3", 101054005)
	
	else
		Adam = set_chara_unknown()
		character2DFull(Adam, "Adam", 101054001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotAdam1 = dot_reserve_ally(101054002, xpos, ypos, layer) 	 --アダン・ドット準備
			dot_set_weapon(dotAdam1, 105010001)	--アダン・武器準備 長弓
		
		elseif style == 2 then  --バルバロイ（武器持ち）
			dotAdam2 = dot_reserve_ally(101054003, xpos, ypos, layer) 	 --アダン・ドット準備
			dot_set_weapon(dotAdam2, 105010001)	--アダン・武器準備 長弓

		elseif style == 3 then  --バルバロイ（武器持ち）
			dotAdam3 = dot_reserve_ally(101054005, xpos, ypos, layer) 	 --アダン・ドット準備
			dot_set_weapon(dotAdam3, 105010001)	--アダン・武器準備 長弓

		else
			dotAdam = dot_reserve_ally(101054001, xpos, ypos, layer) 	 --アダン・ドット準備
			dot_set_weapon(dotAdam, 105010001)	--アダン・武器準備 長弓
		
		end	
		
	end
	
end


-- オーウェン準備
function pbadv_setup_101055_Owen(style,usedot,xpos,ypos,layer)
	
	-- style 1:バルバロイ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then
		Owen1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Owen1, "Owen1", 101055002) 
		
	elseif style == 2 then  --バルバロイ
		Owen2 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Owen2, "Owen2", 101055002)
	
	else
		Owen = set_chara_unknown()
		character2DFull(Owen, "Owen", 101055001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotOwen1 = dot_reserve_ally(101055002, xpos, ypos, layer) 	 --オーウェン・ドット準備
			dot_set_weapon(dotOwen1, 104020001)	--オーウェン・武器準備
		
		elseif style == 2 then  --バルバロイ（武器持ち）
			dotOwen2 = dot_reserve_ally(101055003, xpos, ypos, layer) 	 --ルーシャス・ドット準備
			dot_set_weapon(dotOwen2, 104020001)	--オーウェン・武器準備

		else
			dotOwen = dot_reserve_ally(101055001, xpos, ypos, layer) 	 --オーウェン・ドット準備
			dot_set_weapon(dotOwen, 104020001)	--オーウェン・武器準備
		
		end	
		
	end
	
end	


-- ペレス準備
function pbadv_setup_101056_Perez(style,usedot,xpos,ypos,layer)
	
	-- style 1:バルバロイ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then
		Perez1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Perez1, "Perez1", 101056002) 
		
	else
		Perez = set_chara_unknown()
		character2DFull(Perez, "Perez", 101056001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotPerez1 = dot_reserve_ally(101056002, xpos, ypos, layer) 	 --ペレス・ドット準備
			dot_set_weapon(dotPerez1, 107010001)	--ペレス・武器準備
		
		else
			dotPerez = dot_reserve_ally(101056001, xpos, ypos, layer) 	 --ペレス・ドット準備
			dot_set_weapon(dotPerez, 107010001)	--ペレス・武器準備
		
		end	
		
	end
	
end	


-- レオデグランス準備
function pbadv_setup_101057_Leodgrains(style,usedot,xpos,ypos,layer)
	
	-- style 1:バルバロイ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then
		Leodgrains1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Leodgrains1, "Leodgrains1", 101057002)
		
	else
		Leodgrains = set_chara_unknown()
		character2DFull(Leodgrains, "Leodgrains", 101057001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotLeodgrains1 = dot_reserve_ally(101057002, xpos, ypos, layer) 	 --レオデグランス・ドット準備
			dot_set_weapon(dotLeodgrains1, 101010001)	--レオデグランス・武器準備
		
		else
			dotLeodgrains = dot_reserve_ally(101057001, xpos, ypos, layer) 	 --レオデグランス・ドット準備
			dot_set_weapon(dotLeodgrains, 101020001)	--レオデグランス・武器準備
		
		end	
		
	end
	
end	


-- カレドニア準備
function pbadv_setup_101058_Laiens(style,usedot,xpos,ypos,layer)
	
	-- style 1:バルバロイ
	-- style それ以外:通常
	
	--スタイルに合わせてキャラ２D絵を変える※形を変えたくないのでifは残しておく
	if style == 1 then
		Laiens1 = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Laiens1, "Laiens1", 101058002)
		
	else
		Laiens = set_chara_unknown()
		character2DFull(Laiens, "Laiens", 101058001)
		
	end
	
	--ドットを使うか判定
	if usedot == true then
	
		--スタイルに合わせてキャラドット絵を変える
		if style == 1 then --キラーズ
			dotLaiens1 = dot_reserve_ally(101058002, xpos, ypos, layer) 	 --カレドニア・ドット準備
			dot_set_weapon(dotLaiens1, 108010001)	--カレドニア・武器準備
		
		else
			dotLaiens = dot_reserve_ally(101058001, xpos, ypos, layer) 	 --カレドニア・ドット準備
			dot_set_weapon(dotLaiens, 108010001)	--カレドニア・武器準備
		
		end	
		
	end
	
end	

-- マルイル準備
function pbadv_setup_101062_Maril(usedot,xpos,ypos,layer)
		
		Maril = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Maril, "Maril", 101062001) 
		
	--ドットを使うか判定
	if usedot == true then
			-- 本来であれば101062001　ダミーでティルフィング
			dotMaril = dot_reserve_ally(101062001, xpos, ypos, layer) 	 --マルイル・ドット準備
			dot_set_weapon(dotMaril, 107010001)	--マルイル・武器準備
			
	end
end	


-- クリスティーナ準備
function pbadv_setup_101063_Christina(usedot,xpos,ypos,layer)
		
		Christina = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Christina, "Christina", 101063001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotChristina = dot_reserve_ally(101063001, xpos, ypos, layer) 	 --マルイル・ドット準備
			dot_set_weapon(dotChristina, 101020001)	--マルイル・武器準備
			
	end
end	

-- ブレイズ準備
function pbadv_setup_101063_Blaze(usedot,xpos,ypos,layer)
		
		Blaze = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Blaze, "Blaze", 101066001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotBlaze = dot_reserve_ally(101066001, xpos, ypos, layer) 	 --ブレイズ・ドット準備
			dot_set_weapon(dotBlaze, 108010001)	--ブレイズ・武器準備
			
	end
end	

-- ウレリー準備
function pbadv_setup_101068_Urrie(style,usedot,xpos,ypos,layer)
		
		Urrie = set_chara_unknown()--３Dモデル使わない宣言
		character2DFull(Urrie, "Urrie", 101068001) 
		
	--ドットを使うか判定
	if usedot == true then
			dotUrrie = dot_reserve_ally(101068001, xpos, ypos, layer) 	 --ウレリー・ドット準備
			dot_set_weapon(dotUrrie, 101010001)	--ウレリー・武器準備
			
	end
end	


--コルーチン処理の共通関数
function pbadv_wait_coroutine(_routine)
		while "dead" != coroutine.status(_routine) do
    	coroutine.yield()
	end
end	

function pbadv_setup_101001_Tyrfing_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Tyrfing1, "Tyrfing1", 101001002)
	elseif style == 2 then  --制服歩兵
		character2DFull_Preload(Tyrfing2, "Tyrfing2", 101001001)
	else
		character2DFull_Preload(Tyrfing, "Tyrfing", 101001001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then  --制服歩兵
		else
		end	
	end
end

function pbadv_setup_101009_Noir_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 2 then   --金コート版
		character2DFull_Preload(Noir2, "Noir2", 101009001)
	elseif style == 3 then  --東方諸国連合軍
		character2DFull_Preload(Noir3, "Noir3", 101009003)
	elseif style == 4 then  --幼少期
		character2DFull_Preload(Noir4, "Noir4", 101009005)
	else  --制服のみ
		character2DFull_Preload(Noir, "Noir", 101009002)
	end
	if usedot == true then
		if style == 2 then --金コート版
		elseif style == 3 then  --東方諸国連合軍
		elseif style == 4 then
		else  --制服のみ
		end	
	end
end

function pbadv_setup_101010_Lancelot_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Lancelot1, "Lancelot1", 101010002)
	elseif style == 2 then  --幼少期
		character2DFull_Preload(Lancelot2, "Lancelot2", 101010003)
	elseif style == 3 then  --歩兵
		character2DFull_Preload(Lancelot3, "Lancelot3", 101010001)
	else  -- style 通常
		character2DFull_Preload(Lancelot, "Lancelot", 101010001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then  --幼少期
		elseif style == 3 then  --歩兵
		else  -- style 通常
		end	
	end
end

function pbadv_setup_101011_Guinevere_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Guinevere1, "Guinevere1", 101011002)
	elseif style == 2 then  --ドレス
		character2DFull_Preload(Guinevere2, "Guinevere2", 101011003)
	else
		character2DFull_Preload(Guinevere, "Guinevere", 101011001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then  --ドレス
		else
		end	
	end
end

function pbadv_setup_101012_Dinatan_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Dinatan1, "Dinatan1", 101012002)
	elseif style == 2 then  --傭兵
		character2DFull_Preload(Dinatan2, "Dinatan2", 101012003)
	elseif style == 3 then  --幼少期
		character2DFull_Preload(Dinatan3, "Dinatan3", 101012004)
	else
		character2DFull_Preload(Dinatan, "Dinatan", 101012001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then  --傭兵
		elseif style == 3 then  --幼少期
		else
		end	
	end
end

function pbadv_setup_101013_Gawain_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --敵対差分
		character2DFull_Preload(Gawain1, "Gawain1", 101013002)
	else
		character2DFull_Preload(Gawain, "Gawain", 101013001)
	end
	if usedot == true then
		if style == 1 then   --敵対差分(ドット差分はない）
		else
		end	
	end
end

function pbadv_setup_101014_Tristan_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --通常
		character2DFull_Preload(Tristan, "Tristan", 101014001)
	else
		character2DFull_Preload(Tristan, "Tristan", 101014001)
	end
	if usedot == true then
		if style == 1 then --
		else
		end	
	end
end

function pbadv_setup_101015_Arthur_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --通常
		character2DFull_Preload(Arthur1, "Arthur1", 101015002)
	elseif style == 2 then   --敵対差分
		character2DFull_Preload(Arthur2, "Arthur2", 101015003)
	else
		character2DFull_Preload(Arthur, "Arthur", 101015001)
	end
	if usedot == true then
		if style == 1 then --バルバロイ
		elseif style == 2 then  --敵対差分(ドット差分はない）
		else
		end	
	end
end

function pbadv_setup_101016_Gwenhwymawr_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --通常
		character2DFull_Preload(Gwenhwymawr1, "Gwenhwymawr1", 101016002)
	else
		character2DFull_Preload(Gwenhwymawr, "Gwenhwymawr", 101016001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101017_Maladisant_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Maladisant1, "Maladisant1", 101017002)
	elseif style == 2 then  --療養服
		character2DFull_Preload(Maladisant2, "Maladisant2", 101017003)
	else  -- style 通常
		character2DFull_Preload(Maladisant, "Maladisant", 101017001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then  --療養服
		else  -- style 通常
		end	
	end
end

function pbadv_setup_101018_Ragnar_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Ragnar1, "Ragnar1", 101018002)
	elseif style == 2 then  --キラーズ歩兵
		character2DFull_Preload(Ragnar2, "Ragnar2", 101018002)
	else  -- style 通常
		character2DFull_Preload(Ragnar, "Ragnar", 101018001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then  --キラーズ歩兵
		else  -- style 通常
		end	
	end
end

function pbadv_setup_101019_Isolde_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --通常
		character2DFull_Preload(Isolde1, "Isolde1", 101019002)
	elseif style == 2 then   --通常
		character2DFull_Preload(Isolde2, "Isolde2", 101019002)
	else
		character2DFull_Preload(Isolde, "Isolde", 101019001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then --キラーズ歩兵
		else
		end	
	end
end

function pbadv_setup_101020_Merlin_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Merlin1, "Merlin1", 101020002)
	elseif style == 2 then   --魔術師歩兵
		character2DFull_Preload(Merlin2, "Merlin2", 101020001)
	else 
		character2DFull_Preload(Merlin, "Merlin", 101020001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then --魔術師歩兵
		else
		end	
	end
end

function pbadv_setup_101021_Bruno_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --仮面無
		character2DFull_Preload(Bruno1, "Bruno1", 101021002)
	elseif style == 2 then   --傭兵
		character2DFull_Preload(Bruno2, "Bruno2", 101021003)
	elseif style == 3 then   --歩兵
		character2DFull_Preload(Bruno3, "Bruno3", 101021001)
	else --通常
		character2DFull_Preload(Bruno, "Bruno", 101021001)
	end
	if usedot == true then
		if style == 1 then --仮面無 101021002
		elseif style == 2 then   --傭兵 101021003
		elseif style == 3 then   --歩兵 101021004
		else
		end	
	end
end

function pbadv_setup_101022_Mordred_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --通常
		character2DFull_Preload(Mordred, "Mordred", 101022001)
	else
		character2DFull_Preload(Mordred, "Mordred", 101022001)
	end
	if usedot == true then
		if style == 1 then --
		else
		end	
	end
end

function pbadv_setup_101023_Clarice_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Clarice1, "Clarice1", 101023002)
	else 
		character2DFull_Preload(Clarice, "Clarice", 101023001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101024_Bors_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --通常
		character2DFull_Preload(Bors, "Bors", 101024001)
	else
		character2DFull_Preload(Bors, "Bors", 101024001)
	end
	if usedot == true then
		if style == 1 then --
		else
		end
	end
end

function pbadv_setup_101025_Clare_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --通常
		character2DFull_Preload(Clare1, "Clare1", 101025002)
	else
		character2DFull_Preload(Clare, "Clare", 101025001)
	end
	if usedot == true then
		if style == 1 then --
		else
		end	
	end
end

function pbadv_setup_101026_Percival_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then
		character2DFull_Preload(Percival, "Percival", 101026001)
	else
		character2DFull_Preload(Percival, "Percival", 101026001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101027_Dindrane_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Dindrane1, "Dindrane1", 101027002)
	elseif style == 2 then   --キラーズ歩兵
		character2DFull_Preload(Dindrane2, "Dindrane2", 101027002)
	else
		character2DFull_Preload(Dindrane, "Dindrane", 101027001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101028_Galahad_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --銀卓の騎士
		character2DFull_Preload(Galahad1, "Galahad1", 101028002)
	elseif style == 2 then  --兜有
		character2DFull_Preload(Galahad2, "Galahad2", 101028003)
	elseif style == 3 then  --暴走
		character2DFull_Preload(Galahad3, "Galahad3", 101028004)
	else  -- style 制服
		character2DFull_Preload(Galahad, "Galahad", 101028001)
	end
	if usedot == true then
		if style == 1 then --銀卓の騎士
		elseif style == 2 then  --兜有
		elseif style == 3 then  --暴走
		else  -- style 制服
		end	
	end
end

function pbadv_setup_101029_Astera_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Astera1, "Astera1", 101029002)
	else 
		character2DFull_Preload(Astera, "Astera", 101029001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101030_Elaine_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --顔傷有
		character2DFull_Preload(Elaine1, "Elaine1", 101030002)
	elseif style == 2 then  --ドレス
		character2DFull_Preload(Elaine2, "Elaine2", 101030003)
	elseif style == 3 then  --制服歩兵
		character2DFull_Preload(Elaine3, "Elaine3", 101030001)
	else  -- style 制服
		character2DFull_Preload(Elaine, "Elaine", 101030001)
	end
	if usedot == true then
		if style == 1 then --顔傷有
		elseif style == 2 then  --ドレス
		elseif style == 3 then  --制服歩兵
		else  -- style 制服
		end	
	end
end

function pbadv_setup_101031_Lovein_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Lovein1, "Lovein1", 101031002)
	else
		character2DFull_Preload(Lovein, "Lovein", 101031001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101032_Gareth_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then
		character2DFull_Preload(Gareth, "Gareth", 101032001)
	else
		character2DFull_Preload(Gareth, "Gareth", 101032001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101033_Lyoness_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Lyoness1, "Lyoness1", 101033002)
	else 
		character2DFull_Preload(Lyoness, "Lyoness", 101033001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101034_Excelia_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Excelia1, "Excelia1", 101034002)
	else
		character2DFull_Preload(Excelia, "Excelia", 101034001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101035_Liliana_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Liliana1, "Liliana1", 101035002)
	else
		character2DFull_Preload(Liliana, "Liliana", 101035001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101036_Viena_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Viena1, "Viena1", 101036002)
	else
		character2DFull_Preload(Viena, "Viena", 101036001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101037_Rasia_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Rasia1, "Rasia1", 101037002)
	elseif style == 2 then   --キラーズ歩兵
		character2DFull_Preload(Rasia2, "Rasia2", 101037002)
	elseif style == 3 then   --キラーズ歩兵
		character2DFull_Preload(Rasia3, "Rasia3", 101037001)
	else 
		character2DFull_Preload(Rasia, "Rasia", 101037001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then --キラーズ歩兵
		elseif style == 3 then --制服歩兵
		else
		end	
	end
end

function pbadv_setup_101038_Lola_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Lola1, "Lola1", 101038002)
	elseif style == 2 then --キラーズ（バルバロイ）
		character2DFull_Preload(Lola2, "Lola2", 101038003)
	else 
		character2DFull_Preload(Lola, "Lola", 101038001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then --キラーズ（バルバロイ）
		else
		end	
	end
end

function pbadv_setup_101039_Fren_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --キラーズ
		character2DFull_Preload(Fren1, "Fren1", 101039002)
	elseif style == 2 then --キラーズ（バルバロイ）
		character2DFull_Preload(Fren2, "Fren2", 101039003)
	else 
		character2DFull_Preload(Fren, "Fren", 101039001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then --キラーズ（バルバロイ）
		else
		end	
	end
end

function pbadv_setup_101041_Morgan_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --魔女
		character2DFull_Preload(Morgan1, "Morgan1", 101041002)
	elseif style == 2 then   --魔女 車いす
		character2DFull_Preload(Morgan2, "Morgan2", 101041001)
	elseif style == 3 then   --魔女 瀕死
		character2DFull_Preload(Morgan3, "Morgan3", 101041001)
	elseif style == 4 then   --魔女 気絶
		character2DFull_Preload(Morgan4, "Morgan4", 101041001)
	else 
		character2DFull_Preload(Morgan, "Morgan", 101041001)
	end
	if usedot == true then
		if style == 1 then --魔女
		elseif style == 2 then --魔女 101041003 
		elseif style == 3 then --魔女 101041004 
		elseif style == 4 then --魔女 101041004 
		else
		end	
	end
end

function pbadv_setup_101042_Moronoe_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Moronoe, "Moronoe", 101042001)
	if usedot == true then
	end
end

function pbadv_setup_101043_Mazoe_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Mazoe, "Mazoe", 101043001)
	if usedot == true then
	end
end

function pbadv_setup_101044_Gliten_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Gliten, "Gliten", 101044001)
	if usedot == true then
	end
end

function pbadv_setup_101045_Glitonea_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Glitonea, "Glitonea", 101045001)
	if usedot == true then
	end
end

function pbadv_setup_101046_Gliton_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Gliton, "Gliton", 101046001)
	if usedot == true then
	end
end

function pbadv_setup_101047_Tyronoe_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Tyronoe, "Tyronoe", 101047001)
	if usedot == true then
	end
end

function pbadv_setup_101048_Thiten_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Thiten, "Thiten", 101048001)
	if usedot == true then
	end
end

function pbadv_setup_101049_Thiton_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Thiton, "Thiton", 101049001)
	if usedot == true then
	end
end

function pbadv_setup_101050_Brian_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --通常
		character2DFull_Preload(Brian, "Brian", 101050001)
	else
		character2DFull_Preload(Brian, "Brian", 101050001)
	end
	if usedot == true then
		if style == 1 then --
		else
		end	
	end
end

function pbadv_setup_101051_Lucius_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --制服（キャメロット軍）
		character2DFull_Preload(Lucius1, "Lucius1", 101051002)
	elseif style == 2 then  --バルバロイ
		character2DFull_Preload(Lucius2, "Lucius2", 101051003)
	else  -- style 皇帝
		character2DFull_Preload(Lucius, "Lucius", 101051001)
	end
	if usedot == true then
		if style == 1 then --制服（キャメロット軍）
		elseif style == 2 then  --バルバロイ
		else  -- style 皇帝
		end	
	end
end

function pbadv_setup_101052_Vernarth_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --制服（キャメロット軍）
		character2DFull_Preload(Vernarth, "Vernarth", 101052001)
	else
		character2DFull_Preload(Vernarth, "Vernarth", 101052001)
	end
	if usedot == true then
		if style == 1 then --顔傷有
		else
		end
	end
end

function pbadv_setup_101053_Mathajim_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --バルバロイ
		character2DFull_Preload(Mathajim1, "Mathajim1", 101053002)
	elseif style == 2 then  --バルバロイ
		character2DFull_Preload(Mathajim2, "Mathajim2", 101053002)
	else
		character2DFull_Preload(Mathajim, "Mathajim", 101053001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then  --バルバロイ（武器持ち）
		else
		end	
	end
end

function pbadv_setup_101054_Adam_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then   --バルバロイ
		character2DFull_Preload(Adam1, "Adam1", 101054002)
	elseif style == 2 then  --バルバロイ
		character2DFull_Preload(Adam2, "Adam2", 101054002)
	else
		character2DFull_Preload(Adam, "Adam", 101054001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then  --バルバロイ（武器持ち）
		else
		end	
	end
end

function pbadv_setup_101055_Owen_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then
		character2DFull_Preload(Owen1, "Owen1", 101055002)
	elseif style == 2 then  --バルバロイ
		character2DFull_Preload(Owen2, "Owen2", 101055002)
	else
		character2DFull_Preload(Owen, "Owen", 101055001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		elseif style == 2 then  --バルバロイ（武器持ち）
		else
		end	
	end
end

function pbadv_setup_101056_Perez_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then
		character2DFull_Preload(Perez1, "Perez1", 101056002)
	else
		character2DFull_Preload(Perez, "Perez", 101056001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101057_Leodgrains_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then
		character2DFull_Preload(Leodgrains1, "Leodgrains1", 101057002)
	else
		character2DFull_Preload(Leodgrains, "Leodgrains", 101057001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101058_Laiens_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	if style == 1 then
		character2DFull_Preload(Laiens1, "Laiens1", 101058002)
	else
		character2DFull_Preload(Laiens, "Laiens", 101058001)
	end
	if usedot == true then
		if style == 1 then --キラーズ
		else
		end	
	end
end

function pbadv_setup_101062_Maril_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Maril, "Maril", 101062001)
	if usedot == true then
	end
end

function pbadv_setup_101063_Christina_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Christina, "Christina", 101063001)
	if usedot == true then
	end
end

function pbadv_setup_101063_Blaze_preload(usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Blaze, "Blaze", 101066001)
	if usedot == true then
	end
end

function pbadv_setup_101068_Urrie_preload(style,usedot,xpos,ypos,layer)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
		character2DFull_Preload(Urrie, "Urrie", 101068001)
	if usedot == true then
	end
end

-- 現代編主人公じゃなくても使えるけど現代編主人公の画像初期化
function setup_player_2d(styleId)
local actor
   actor = set_chara_unknown()
   character2DFull(actor, tostring(styleId), styleId) 
   return actor
end

-- 現代編主人公じゃなくても使えるけど現代編主人公のドット初期化
function setup_player_dot(styleId,x,y,layer,weaponId)
local dotActor
   if weaponId == nil then 
      weaponId = 101010001
   end
   dotActor = dot_reserve_ally(styleId, x, y, layer)
   dot_set_weapon(dotActor, weaponId)
   return dotActor
end

-- 現代編プレイヤーの初期化
function pbadv_setup_player(x,y,layer,weaponId)
	local styleId = get_player_styleId()
	playerFace = setup_player_2d(styleId)
	playerDot = setup_player_dot(styleId,x,y,layer,weaponId)
end
