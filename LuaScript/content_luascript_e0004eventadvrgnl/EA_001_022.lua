-- このluaスクリプトは、EA_001_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",235,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera004 = SetTemplate("Actor004",-50,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
set_pos(Actor004,{5.26, 0, -2.94,   269})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ケイ", "0020")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Normal")

	--★★ケイ★★:停学だ
	Talk(Actor001,"CHRNAME_KAY","speech","N","EA_001_022002")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0020")
-- ▲直接出力
	close_cutin()
	change_face(Actor002,"Pain")

	--★★ラグネル★★:ぐぅ～っ！？<br>カワイイのに！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_022003")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:私の護衛兵から報告を受けた<br>『実力に関しては申し分ない』と
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_022004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ローラ", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:や、やったぁ～
	Talk(Actor003,"CHRNAME_LOLA","speech","L","EA_001_022005")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ケイ★★:………『だが全然アップリケが外れない』と
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_022006")

-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラグネル★★:外れちゃ困るでしょ、アップリケ
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_022007")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ケイ★★:兵たちを腕づくで<dot>説得</dot>するところまでは<br>まぁ兵も合意のうえだ、良いとしよう──
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_022008")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力

	--★★ケイ★★:いやいやまったく良くないが<br>ウン千万歩譲って良しとしたとしてもだ
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_022010")

-- ▼直接出力
change_face(Actor003,"Sad")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ケイ", "0018")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ケイ★★:兵装にカワイイアップリケをつけたり<br>首元に猫耳つきのフードをつけてはいかんだろう
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_022011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ケイ", "0033")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ケイ★★:それで<br>「ウワすごくぬいぐるみ欲しいわ～」となるか？
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_022012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:わかんないじゃん！<br>やってみなきゃ！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_022013")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.2)
Appear(Actor004)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,1.293, 0, 0.296, 3.0)
wait_time(3.0)
turn_chara(Actor004,-91,0.35)
wait_time(0.35)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:そのビッグマウスこそ<br>ラグネルの急所よね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_022015")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラグネル★★:い、イゾルデちゃん、裏切り！？<br>あたしたちの熱いハグはどこいったの！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_022016")


	--★★イゾルデ★★:五月祭直前、アーサー王はその準備で多忙<br>ガウェインも王の手伝いでベッタリ──
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_022018")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:王抜きで停学や廃部を決めるのはどうなのかしら<br>こんないきなりではガウェインも悲しむわ
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_022019")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Sad")

	--★★ノワール★★:イゾルデ…<br>キミはどっちの味方なんだ…？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_001_022020")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力

	--★★ケイ★★:………ならば停学には猶予をつけよう<br>兵士たちのアップリケを取り外すことで
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_022021")

	PlayAction(Actor002,"to Bow")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0021")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:………スミマセンデシタ<br>アリガトゴザマシタ
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_022023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ケイ★★:気にするな、３日後の五月祭が終わり次第<br>停学も廃部も執行される。わずかな猶予だよ
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_022025")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ローラ", "0025")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ローラ★★:…へ、兵士さんたちのアップリケを外すので<br>今日一日は終わっちゃうから──
	Talk(Actor003,"CHRNAME_LOLA","speech","L","EA_001_022026")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:ぬいぐるみ作りなんて間に合わないでしょうね<br>まぁ時間も勝機も元々なかったようなものだけど
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_022027")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera006)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ケイ★★:身の丈に合う行いを
	Talk(Actor001,"CHRNAME_KAY","speech","L","EA_001_022029")

	EndPlay()
end

