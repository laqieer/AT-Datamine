-- このluaスクリプトは、MA_01106_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")

	--★★トリスタン★★:カン高い声は嫌いだな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050002")

	PlayAction(Actor004,"to  Std_Joy")

	--★★キャメロット騎士学術院（女）②★★:きゃー！トリスタンくんっ！<br>しびれる～！
	Talk(Actor004,"NPCNAME_0146","speech","N","MA_01106_050003")


	--★★トリスタン★★:黙ってくれる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")

	--★★キャメロット騎士学術院（女）★★:トリスタンくん！<br>もっと言って～！！
	Talk(Actor003,"NPCNAME_0147","speech","N","MA_01106_050005")

	change_face(Actor002,"Smile")

	--★★トリスタン★★:くちびる、縫い付けてあげようか
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")

	--★★キャメロット騎士学術院（女）③★★:ぎゃー！トリスタンくんになら<br>されてもいい～！！
	Talk(Actor005,"NPCNAME_0148","speech","N","MA_01106_050008")

	PlayAction(Actor003,"to  Std_Surp")

	--★★キャメロット騎士学術院（女）★★:待って！この子気絶してる！<br>トリスタンくん見て気絶してる！
	Talk(Actor003,"NPCNAME_0147","speech","N","MA_01106_050009")

	PlayAction(Actor005,"to  Std_Joy")

	--★★キャメロット騎士学術院（女）③★★:待って待って！きゃー！
	Talk(Actor005,"NPCNAME_0148","speech","N","MA_01106_050010")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
Appear(Actor001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ノワールくん、いる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:すごい人気だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_050013")


	--★★トリスタン★★:調律の取れていない楽器は<br>聞くに堪えないね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050014")

	PlayAction(Actor005,"to  Std_Surp")

	--★★キャメロット騎士学術院（女）③★★:辛辣～！奏者ジョークが辛辣～！
	Talk(Actor005,"NPCNAME_0148","speech","N","MA_01106_050015")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:いい加減にしてほしいんだけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050017")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
se_play("SE_ADV_MA_01106_05_Crowds")
wait_time(CHARA_IN_IN +CHARA_IN_WAIT)
wait_time(1.0)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:キャメリアード奪還、お疲れ様<br>大金星だね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050019")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:わざわざそんなことを言いに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_050020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:まさか
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050021")

	change_face(Actor002,"Smile")

	--★★トリスタン★★:これを機に増長したりしてくれていると<br>見応えがあっていいなあ、なんて
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050022")

	open_select_window_tag(Actor001,"Normal","MA_01106_050024","MA_01106_050025","MA_01106_050026")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の素行に問題は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_050028")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★トリスタン★★:ないね<br>監視のし甲斐がないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050029")

	change_face(Actor002,"Smile")

	--★★トリスタン★★:大きな問題起こしてくれれば<br>大手を振って取り押さえられるのにさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:まさか、ディナタンにも監視を？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_050032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボクとイゾルデの共通見解でね<br>キミは真面目で寒気がするいい人だけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050034")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:キミの妹は少し<br>なにをやらかすかわからないっていう印象なんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050035")

	change_face(Actor002,"Smile")

	--★★トリスタン★★:緊張感をもって<br>監視を続けさせてもらうよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050037")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:ギネヴィアやガウェインたちのおかげだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_050039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★トリスタン★★:模範解答！いいね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050040")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:面白味がなくて<br>逆に怪しく思えてくるよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050041")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★トリスタン★★:出て行ってほしいと思ってるんだ<br>キミには
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050043")


	--★★トリスタン★★:円卓から<br>この学園から
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050044")


	--★★トリスタン★★:キミが不協和音なら<br>たとえすごい才覚の持ち主だったとしてもね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:もうほかに行く場所なんてないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_050046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★トリスタン★★:うん、だろうね。だから頑張って？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050047")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:疑うのがボクのお仕事<br>あんまり目くじら立てられるのも怖いな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050048")


	--★★トリスタン★★:そしてキミの次のお仕事の話<br>放課後、円卓の間に来てくれる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:最後の休暇の<br>話をしよう
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_050051")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
MobsNo = 1
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
