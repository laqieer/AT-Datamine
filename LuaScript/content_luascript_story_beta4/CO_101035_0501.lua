-- このluaスクリプトは、CO_101035_0501.csv の ADV シートから自動生成されました --
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

	--★★リリアーナ★★:ノワールさん/これから畑に行こうと思うんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101035_05010004","CO_101035_05010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん、行こう/ちょうど誘おうと思ってたところだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05010007")

	change_face(Actor002,"Smile")

	--★★リリアーナ★★:ありがとうございます！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05010008")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:ディナタンとクレアからも/オーケーをもらってます
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05010009")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:ただ、ふたりは準備に/もう少し時間がかかるそうなので
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05010010")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:待っているあいだ/買い出しに付き合っていただけませんか？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05010011")

	change_face(Actor001,"Smile")

	--★★ノワール★★:お安い御用だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05010012")

	reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ5_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:一緒に行きたいところだけど…/ちょっと他に用事があるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_05010014")

	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:いえいえっ、大丈夫です！/お気になさらないでください
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_05010015")

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
