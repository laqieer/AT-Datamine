-- このluaスクリプトは、MA_01C111_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
DontChangeRandomCamera(true)
force_eyesync(Actor002,"Close")
reserve_eyesync(Actor002,"Close")
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor002,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:だが、二曲目を歌い始めた直後<br>ディナタンはその場で倒れてしまうのだった
	Talk(Actor004,"telop","narration","N","MA_01C111_011001")


	--★★テロップ★★:
	Talk(Actor004,"telop","narration","N","MA_01C111_011002")


	--★★テロップ★★:ううん…
	Talk(Actor004,"telop","narration","N","MA_01C111_011003")


	--★★テロップ★★:
	Talk(Actor004,"telop","narration","N","MA_01C111_011004")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ううん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタン！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010003")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:ディーナ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_010004")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
lookat_weight(Actor001,0.7,0.03,0.7,0)
lookat_weight(Actor003,0.6,0.03,0.7,0)
reserve_eyesync(Actor002,"Auto")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:兄さん…マァル…<br>私…どうしたんだっけ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ステージの途中で倒れたんだ<br>それからずっと眠ってて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010006")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:そう…なんだ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C111_010008","MA_01C111_010009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:心配したよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010011")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:ごめんね、兄さん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010012")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:私ってば<br>いつも兄さんに心配かけてばっかりだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010013")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なに言ってるんだ。兄妹だろ、俺たち<br>妹は兄貴にいくらでも迷惑かけていいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010014")

-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄妹…うん、そうだよね<br>ありがとう、兄さん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:マルディサントなんて<br>ずっと泣いてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Anger")
	change_face(Actor003,"Anger")

	--★★マルディサント★★:なっ…テメェ！<br>勝手なこと言ってんじゃねえ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","N","MA_01C111_010018")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:マァル、目が赤い…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010019")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",2)
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★マルディサント★★:ぐっ…これはアレだよ！<br>さっきニンジン食べたからだよ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_010020")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:なあ、ディーナ<br>あんまり無茶すんなよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_010022")


	--★★マルディサント★★:よくわかんねえ場所に１ヶ月もいたんだろ？<br>体調が良いはずなんてねえんだって
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_010023")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★マルディサント★★:アンタまでいなくなったらアタシは――
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_010024")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:マァル…ごめんね…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★マルディサント★★:…いや。アタシこそキラーズなんだから<br>アンタの変化に気づくべきだった
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_010026")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:そんなことないよ<br>ありがとう…マァル
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン、体調はどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:うん、大丈夫<br>ちょっとぼんやりしてるだけ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010029")


	--★★ノワール★★:イゾルデの診察では<br>疲れがたまってたんじゃないかって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010030")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:………
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010031")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん、ディナタン<br>ずっと無理させてたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010032")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:なんで兄さんが謝るの？<br>兄さんのほうがずっと大変なのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:私にもこれくらい頑張らせてよ<br>私は兄さんのキラーズなんだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…もう。なにその顔<br>兄さんのほうが病気みたいだよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010036")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:外に出て気晴らしでもしてきたら？<br>私はもう大丈夫だし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_010037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…あぁ、そうするか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(true)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
-- ▲直接出力

	--★★ノワール★★:マルディサント<br>ディナタンのこと頼むよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_010039")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:オニーサンに言われずとも?
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_010040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
