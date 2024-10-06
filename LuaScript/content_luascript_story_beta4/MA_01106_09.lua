-- このluaスクリプトは、MA_01106_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_pos(Actor004,{-3.5, 0.15,27})
set_pos(Actor005,{-3.5,0.15,26,})
turn_chara(Actor004,156.946,0)
set_enable_auto_lookat(Actor003, false)
turn_chara(Actor005,-8.88,0)
keep_delay_ik_lookat(Actor004,Actor005,"J_Head",1)
keep_delay_ik_lookat(Actor005,Actor004,"J_Head",1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ディナタン★★:あっ、押しますね
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_090002")


	--★★モルガン★★:いいえ、だいじょうぶ
	Talk(Actor003,"CHRNAME_MORGAN","speech","N","MA_01106_090003")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Laugh")

	--★★マルディサント★★:この役目は譲れねえな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090005")

	change_face(Actor003,"Smile")

	--★★モルガン★★:ほおら
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_090006")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★マルディサント★★:アタシ<br>もっかいリンゴ食いてえ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:せんせのリンゴ、食いてえわ<br>いつも…妹と一緒に食ったリンゴ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090008")


	--★★モルガン★★:いい子ね。マルディサント
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_090009")

	PlayAction(Actor002,"to  Std_Worry")

	--★★マルディサント★★:ディナタンじゃねえんだから
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:ふふ。見習ってくれていいよ？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_090011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:うるせ<br>アンタは大好きなオニーサンのとこ行きな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090012")

	change_face(Actor002,"Sad")

	--★★マルディサント★★:…礼言っといてくれよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090013")


	--★★マルディサント★★:前の戦い…オニーサンが勝ってなきゃさ<br>こんな休暇すらなかったかもしんねえ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090014")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:直接言えば良いのに
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_090015")

	change_face(Actor002,"Laugh")

	--★★マルディサント★★:あんたの口からのほうが<br>喜ぶだろ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:た　し　か　に
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_090018")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★マルディサント★★:てめえ…
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090020")

	PlayAction(Actor001,"to Greet_one")

	--★★ディナタン★★:えへへ…<br>またあとでね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_090021")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor001)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力

	--★★マルディサント★★:なんでセンソー中にリンゴ狩りなんだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090023")

	PlayAction(Actor003,"to  Std_Joy")

	--★★モルガン★★:貴方が嬉しがるからっ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_090025")

	change_face(Actor002,"Smile")

	--★★マルディサント★★:うそばぁ～っか
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_090026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
