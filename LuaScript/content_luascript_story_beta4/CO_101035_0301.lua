-- このluaスクリプトは、CO_101035_0301.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★リリアーナ★★:あっ、ノワールさん/これから畑に行こうと思ってるんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101035_03010004","CO_101035_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:それなら俺も行くよ/人手があったほうがいいだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03010007")

	change_face(Actor002,"Smile")

	--★★リリアーナ★★:ありがとうございます！/ふたりなら仕事もはかどりますし…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03010008")

	change_face(Actor002,"Shy")

	--★★リリアーナ★★:なにより、その…楽しい、です…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03010009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03010010")

	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:な、なんでもありませんっ！/い、行きましょう！！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03010011")

	reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:一緒に行きたいところだけど…/ちょっとほかに用事があるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03010013")

	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:いえいえっ、大丈夫です！/お気になさらないでください
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03010014")

	system.Cancel()

	goto Block1end

::Block1end::
	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")
end
