-- このluaスクリプトは、MA_01A109_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1) 
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002,1) 
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor004,Actor001,1) 
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガウェイン★★:わかるように言えよ！！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_090002")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:言ってるじゃん！！<br>さっきからずっと！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01A109_090003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "激怒")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor001,"Anger")

	--★★ガウェイン★★:俺はお前じゃねーんだ！<br>ハッキリ言ってくんなきゃわかんねーよ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","N","MA_01A109_090004")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "苦しみ")
-- ▲直接出力
	on_cutin(2,Actor002,"Sad")

	--★★ラグネル★★:あたしだって！！<br>…あたし、だって、さぁ…！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","N","MA_01A109_090005")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ラグネル★★:わかんないから、ちゃんと言えないよ………！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","N","MA_01A109_090007")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
character_in_move_run_offset(Actor003,CharaPos007,0,0,-5,0.8,0.3)
setup_small_camera_end(Camera003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:…なにかあったのか？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A109_090008")

-- ▼直接出力
 --PlayPartVoice("兵士3", "肯定")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:これはノワール様<br>兵士たちの装備が複数消えておりまして
	Talk(Actor004,"NPCNAME_0082","speech","N","MA_01A109_090009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガウェイン★★:物取りが出たんじゃねーかって<br>話してたんだよ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_090010")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力

	--★★ラグネル★★:せっかく兵士さんたちの装備を<br>修繕できたらなあって思ったのに…
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01A109_090011")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:衛兵や警吏が見回っていたはずだろ？<br>装備なんて持ち歩いたら目立つし
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A109_090012")


	--★★ラグネル★★:…あてつけがましいでしょ<br>こうまでバレバレのやりかたされるとさ
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01A109_090013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:だからさ、ちょっと待てよソレがわかんねえ<br>なんでわかった感じになってんだよさっきから
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_090014")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:だからあ、ログレス兵の装備が盗まれたんだよ？<br>それも沢山！外部の犯行とも考えにくいし！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01A109_090015")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:学園に出入りしていた人間の仕業だ<br>そして起こったログレス兵による虐殺…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A109_090016")

	change_face(Actor001,"Normal")

	--★★ガウェイン★★:だから？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_090017")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ラグネル★★:だからあ！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01A109_090018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:あのね、あー、んー………<br>もお…自分で考えて
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01A109_090020")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
--ラグネル退場
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
se_play("SE_ADV_MA_01105_24_Footstep")
wait_time(2.2)
Hide(Actor002)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:ガウェイン、本当にわかってないのか？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A109_090022")

-- ▼直接出力
setup_small_camera_end(Camera001)
turn_lookat(Actor001,Actor003,0)
SkipOffsetCamera(Camera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:ローマの仕業かもってこったろ？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_090023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ど、どうしてわかってて…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A109_090024")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:なんでだろ…なんでだろうな
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_090025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガウェイン★★:ちょっと認めたくねーのかも
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_090027")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor004")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
