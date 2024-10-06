-- このluaスクリプトは、CO_101035_0901.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Liliana","101035001","101035001","content_animationpack_101_101lili","MotionPack_101Lili","Com_Std01_Loop_f")

	-- 屋外用と校内用のクレアを両方設定
	-- ※エリア配置が2パターンあるがスクリプト内ではどちらなのか判別できないため、どちらでも対応できるように両方のクレアを同時に設置
	-- ※カメラによってはもう片方のクレアが見えてしまう可能性があるので注意
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")

	-- 屋外用
	set_pos(Actor003, {0.259+1, 1.2-3, 11.64+0})	-- リリアーナの座標から相対配置。ただし一旦画面外に配置
	set_rot(Actor003, {0,180+30,0})
	set_animationcontroller_path(Actor003, "content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop")

	-- 校内用
	set_pos(Actor004, {-6.42+1, 0.01-3, -24.24+0})	-- リリアーナの座標から相対配置。ただし一旦画面外に配置
	set_rot(Actor004, {0,-90,0})
	set_animationcontroller_path(Actor004, "content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop")

	off_active(Actor003)
	off_active(Actor004)

end

function Play()
	StartPlayActive()

	--★★リリアーナ★★:ノワールさん/そろそろ畑の様子を見に行こうと思うんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101035_09010004","CO_101035_09010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も行くよ/マルコさんの具合も気になるしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09010007")


	CloseTalkWindow()

	fadeout(0,0,0,1.0, CHARA_IN_IN)
	wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

	set_pos(Actor003, {0.259+1, 1.2, 11.64+0}) -- 屋外用
	on_active(Actor003)

	set_pos(Actor004, {-6.42+1, 0.01, -24.24+0}) -- 校内用
	on_active(Actor004)

	fadein(CHARA_IN_OUT)
	wait_time(CHARA_IN_OUT)


	change_face(Actor003,"Normal")

	--★★クレア★★:わたしも手伝うわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09010009")

	change_face(Actor002,"Smile")

	--★★リリアーナ★★:はい、もちろん！/頼りにしています
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09010010")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ふたり、すっかり仲良くなったなぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09010011")

	reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ9_2")

	fadeout(0,0,0,1.0, CHARA_IN_IN)
	wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:一緒に行きたいところだけど…/ちょっと他に用事があるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09010013")

	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:いえいえっ、大丈夫です！/お気になさらないでください
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09010014")

	system.Cancel()

	goto Block1end

::Block1end::
	EndPlayActive()

	kill(Actor003)	-- 念のため追加登録したキャラをデモ終了時に破棄
	kill(Actor004)	-- 念のため追加登録したキャラをデモ終了時に破棄

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
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
end
