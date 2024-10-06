-- このluaスクリプトは、MA_01C900_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_common_look_at(Actor001,Actor002,1.0)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-0.417, 0, -13.52353})
set_rot(Actor004,{0, 26.566,0})
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:ランチセットふたつ、おまちど～
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040002")


	--★★ガレス★★:ふたりが食堂に来てくれて嬉しいぞ<br>最近、みんな全然来てくれないんだ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040003")

-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:そうなの…どうしてかしら
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01C900_040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "納得")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★トリスタン★★:ボクにはわかる気がするよ
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01C900_040005")

-- ▼直接出力
 --PlayPartVoice("ガレス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガレス★★:どうして？
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:今までに比べて、あまりにも静かすぎるから<br>辛くなる人もいるんじゃないかな
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01C900_040007")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガレス★★:…よく食べる人もいなくなったしな
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040009")

-- ▼直接出力
 --PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:ガレス…
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01C900_040010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★トリスタン★★:喧騒も聞こえなくなると寂しいものだね<br>あの頃は、耳障りだと思っていたけど
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01C900_040011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to Sit01_Loop")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★トリスタン★★:…でも、嫌いじゃなかった
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01C900_040012")

-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガレス★★:だったら、また賑やかにすればいい
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040013")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor003, 1.0, 0.5, 0.5, 0.2,1.0)
keep_ik_lookat(Actor003,Actor001,"J_Head")
 --PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガレス★★:なあ、トリスタン<br>ひとつお願いしてもいいかな？
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_delay_weight(Actor001, 1.0, 0.5, 0.5, 0.2,1.0)
keep_ik_lookat(Actor001,Actor003,"J_Head")
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★トリスタン★★:お願い？
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01C900_040015")

-- ▼直接出力
 --PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガレス★★:竪琴を引いてほしいんだ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040016")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:素敵な音楽を流せば<br>きっとみんな集まってくれる！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040017")


	--★★ガレス★★:そして集まってきたひとたちに向けて<br>美味そうなご飯の香りを漂わせて…
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040018")


	--★★ガレス★★:そしたらきっと、みんなご飯が食べたくなる！<br>賑やかであったかい食卓の復活だ！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040019")

-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:そう上手くいくかしら
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01C900_040020")

-- ▼直接出力
 --PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Smile")

	--★★ガレス★★:大丈夫だ！トリスタンの竪琴と<br>わたしのご飯があれば
	Talk(Actor003,"CHRNAME_GARETH","speech","N","MA_01C900_040021")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:賑やかで楽しくて、あたたかい食卓を作れる！<br>棄てた人が後悔するくらいのな
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C900_040022")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★トリスタン★★:棄てた人、ね
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01C900_040023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_reset(Actor001,0.7)
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★トリスタン★★:いいね。それ<br>後悔、させてあげよう
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01C900_040024")


	--★★トリスタン★★:それがきっと<br>ボクたちがあいつにしてやれることだ<br>?
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01C900_040025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
