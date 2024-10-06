-- このluaスクリプトは、CO_101035_0201.csv の ADV シートから自動生成されました --
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

	--★★リリアーナ★★:えっと、今日買わなきゃいけないのは…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101035_02010004","CO_101035_02010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:やあ、リリアーナ/こんなところでなにしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02010007")

	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:ノワールさんっ！？/こ、こんにちは…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:買い物の途中か？/重いものを買うようなら荷物持ちを手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02010009")

	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あの、えっと、その…/ひとりで大丈夫です…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02010010")


	fadeout(0,0,0,1.0, CHARA_IN_IN)
	wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

--	off_active(Actor002)
	set_pos(Actor002, {0.259+0, 1.2-3, 11.64+0})

	fadein(CHARA_IN_OUT)
	wait_time(CHARA_IN_OUT)


	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん、怪しい/追いかけてみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02010012")

	reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ2_2")

	-- 場面転換用の終了処理
	--EndPlayActive()
	EndTalk()
	demo_next()

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02010014")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:あれとそれは買ったから、あとは…/ブツブツ…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02010015")

	system.Cancel()

	-- 通常の終了処理
	EndPlayActive()

	goto Block1end

::Block1end::

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
