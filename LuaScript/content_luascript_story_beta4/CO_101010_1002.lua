-- このluaスクリプトは、CO_101010_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera002 = SetTemplate("Actor002",-35,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera004 = SetTemplate("Actor004",-15,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
load_image("103050220","content_still_10305022_image","103050220_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0050")
-- ▲直接出力

	--★★ノワール★★:連れてきたかったところってここか？<br>円卓の間じゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_10020002")

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,70,0.4)
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:そうだ<br>円卓の間だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020003")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookat_delay_weight(Actor001, {1.0, 0.08, 0.4, 0.6} ,0.5)
-- ▲直接出力

	--★★ランスロット★★:聞いていると思うが<br>師匠はかつてこの国の騎士だった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020004")


	--★★ランスロット★★:剣の腕前にかけては比肩する者なく<br>その騎士としての振る舞いは誰もが称賛していた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:だからこそ下されたのだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020006")


	--★★ランスロット★★:「世界平和の願いを叶える聖杯を探し求め<br>その聖杯へ導く妖精を守る」という任務が
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020007")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0052")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ログレスをひとり離れ<br>リムニーナ村に来た理由ってのは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_10020008")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:ブルーノは<br>誉れ高き円卓の騎士だった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020010")


	--★★ランスロット★★:お前の入学が決まったあの日<br>アーサーは「席が空いている」と言っていた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020012")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★ランスロット★★:正確には違う<br>この席は空いたままにされていたんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:お前のためにな<br>ブルーノ・ル・ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020015")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_10020017","CO_101010_10020018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:父さんがそこまでの騎士だったとは<br>思いもよらなかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_10020020")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:でも、その後を継ぐとなると<br>責任重大だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_10020021")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:だからといって<br>今さら逃げたりはしないだろう？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020022")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:するわけないだろ<br>恥をかかせるわけにはいかない。父さんにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_10020023")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Serious")

	--★★ノワール★★:…兄さんにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_10020024")

-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0053")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:連れてきてくれてありがとう<br>円卓の間に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_10020026")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:キャメロット騎士学術院に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_10020028")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:あらためて言わせてくれ<br>ようこそ、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_10020030")

	goto Block1end

::Block1end::
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
se_play("SE_ADV_MA_01104_10_Foot")
se_play("SE_ADV_MA_01B112_12_Foot")
wait_time(CHARA_IN_WAIT + 3)
Hide(Actor001)
Hide(Actor002)
Appear(Actor003)
Appear(Actor004)
lookat_delay_weight_reset(Actor003 , 1)
set_enable_auto_lookat(Actor003, true)
setup_small_camera_start(RndCamera009)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール2★★:そうか…<br>父さんもここに座っていたのか
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020032")


	--★★ノワール2★★:あの日、あんたが俺を円卓に推薦したときは<br>本当にどうかしちまったのかと思ったけど
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020033")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール2★★:きちんと理由があってのことだったんだな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020034")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ランスロット2★★:「どうかしちまったのかと思った」だと？<br>まったくお前というヤツは…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","CO_101010_10020035")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット2★★:兄の心、弟知らずだな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","CO_101010_10020036")

-- ▼直接出力
keep_ik_lookat(Actor003, Actor004, "J_Head")
lookat_delay_weight(Actor003, 0.6,0.5,0.6,0.4,0.7)
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0049")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール2★★:仕方ないだろ、あのときは状況が状況だ<br>それにあんたはなにも教えてくれなかったし…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
keep_ik_lookat(Actor003, Actor004, "J_Head")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ノワール2★★:弟の心、兄知らずだ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020038")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
turn_chara(Actor003,35,0.2)
set_pos(Actor001,{-1.13,0,-2.38})
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ランスロット2★★:…ふっ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","CO_101010_10020039")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール2★★:…ははっ！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020040")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット2★★:ただ<br>推薦人として困ったことがあるんだ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","CO_101010_10020042")

-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0052")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール2★★:困ったこと？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020043")


	--★★ランスロット2★★:聞いてくれるか？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","CO_101010_10020044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール2★★:もちろんだ<br>恩返しをさせてくれ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020045")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット2★★:推薦されて入ったはいいが<br>そいつの成績がイマイチでな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","CO_101010_10020046")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ランスロット2★★:剣術にかけては合格点をやれるものの<br>それ以外がサッパリなんだよ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","CO_101010_10020048")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール2★★:うっ！？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020049")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット2★★:これでは面目が立たん、父さんに
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","CO_101010_10020050")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール2★★:こ、ここで父さんの名を出すのは<br>卑怯じゃないか…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020052")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ランスロット2★★:ならばどうする？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","CO_101010_10020053")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ノワール2★★:ああ、もうわかったよ！！<br>やってやるさ！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020054")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール2★★:父さんから託されたもの<br>あんたがここで培ってきたもの──
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101010_10020055")

-- ▼直接出力
CloseTalkWindow()
show_image("103050220", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) 
set_scale_image(0.9,0.9) 
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール2★★:寄越してくれよ。全部
	Talk(Actor003,"CHRNAME_NOIR","simple","N","CO_101010_10020056")


	--★★ノワール2★★:すべて積み重ねて<br>騎士の高みに登り詰めてやる
	Talk(Actor003,"CHRNAME_NOIR","simple","N","CO_101010_10020058")

-- ▼直接出力
wait_time(1.2)
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット2★★:………強いな、ノワール
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","CO_101010_10020060")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力

	--★★ノワール2★★:あんたほどじゃない
	Talk(Actor003,"CHRNAME_NOIR","simple","N","CO_101010_10020061")


	--★★ランスロット2★★:昔から<br>ずっと思っていたが──
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","CO_101010_10020062")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力

	--★★ランスロット2★★:見上げたやつだよ。本当に
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","CO_101010_10020063")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ランスロット_コミュランク", "ランスロット_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103050220","content_still_10305022_image","103050220_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
