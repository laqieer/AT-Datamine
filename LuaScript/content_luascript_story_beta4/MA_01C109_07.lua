-- このluaスクリプトは、MA_01C109_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_006)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor003, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("マルディサント","落胆")
-- ▲直接出力

	--★★マルディサント★★:いけねえことをしちまうのは<br>ダメなもんかな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070002")

-- ▼直接出力
 --PlayPartVoice("ディナタン","悩む")
-- ▲直接出力

	--★★ディナタン★★:なに？それ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070004")

-- ▼直接出力
 --PlayPartVoice("マルディサント","悩む")
-- ▲直接出力

	--★★マルディサント★★:こっちのハナシでもあるし<br>そっちのハナシでもある
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:なにそれぇ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マルディサント★★:どうなんだろな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…マァルがしたいと思うことなら<br>私、応援するけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070008")

-- ▼直接出力
 --PlayPartVoice("マルディサント","笑い")
-- ▲直接出力

	--★★マルディサント★★:オニーサンをイジることとか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070009")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ディナタン","怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:それはダメ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント","落胆")
-- ▲直接出力

	--★★マルディサント★★:だよな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:アンタのそういうとこ<br>アタシはイイって思うよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:えへへ…<br>意味わからないけど、ありがと
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070013")

-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_delay_weight(Actor003, {1.0, 0.08, 0.5, 0.6} ,0.5)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.5)
-- ▲直接出力
-- ▼直接出力
 --turn_lookat(Actor003,Actor001, 0)
 --PlayPartVoice("マルディサント","挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:それはそうと<br>オニーサンに聞きてえんだけどよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★マルディサント★★:ディーナがオニーサンとＧＳしてから<br>なんつーかヘンなカンジなんだよな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070015")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070016")

-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_070017")

-- ▼直接出力
 --PlayPartVoice("マルディサント","落胆")
-- ▲直接出力

	--★★マルディサント★★:新しい力を感じるっつーかなんつーか…<br>うまく言えねーんだけど
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070018")


	--★★マルディサント★★:ディーナがアンタのキラーズになったあと<br>ディーナのキラーズのアタシはどうなる？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C109_070020","MA_01C109_070021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん<br>俺のキラーズでもある、のか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_070023")

-- ▼直接出力
 --PlayPartVoice("マルディサント","悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:そうかぁ？<br>アンタと繋がってるカンジはねえけどな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070024")

-- ▼直接出力
 --PlayPartVoice("ディナタン","悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:あくまでもマァルは<br>私のキラーズなんじゃないかな？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:それがいーや、気楽でさ<br>仲良し兄妹の輪の仲に今さら入れねーよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070026")

-- ▼直接出力
 --PlayPartVoice("ディナタン","照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:仲良し兄妹…そ、そうかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マスターは<br>ディナタンのままなんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_070030")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:うへ！じゃ、継承者のキラーズって<br>ふたつの役割があんのか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070031")

	change_face(Actor003,"Surprise")

	--★★マルディサント★★:めんどくせ～<br>ってか、ディーナじゃなきゃ無理だろ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070032")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:なるべくしてくっついたんじゃね、アンタら<br>アンタらっつーか、アタシもか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070033")

-- ▼直接出力
 --PlayPartVoice("ディナタン","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…これって褒められてるの？<br>いいように扱われてるだけ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070034")

	goto Block1end

::Block1end::
-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor004)
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor002, true)
change_face(Actor002,"Normal")
lookat_delay_weight_reset(Actor003 , 1)
turn_chara(Actor003, -164, 0)
turn_lookat(Actor002,Actor004, 0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン","納得")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:でも先生、羨ましいなぁ<br>ノワールくんとディナタンちゃんの関係
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01C109_070036")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
turn_lookat(Actor001,Actor004, 0)
 --PlayPartVoice("マルディサント","肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:モルガンせんせとアーサー王も<br>仲が悪いってワケじゃないっしょ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070037")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:そうねえ<br>先生はもっと仲良くしたいんだけど
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01C109_070038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:それこそ<br>夢に見ちゃうくらいね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01C109_070039")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★モルガン★★:でも、難しいものなのよ<br>大人になっちゃうとね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01C109_070040")

-- ▼直接出力
 --PlayPartVoice("マルディサント","落胆")
-- ▲直接出力

	--★★マルディサント★★:…ジャマが入ったり？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_070041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:さぁ、どうかしら？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01C109_070042")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.9)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン","肯定3")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★モルガン★★:ディナタンちゃん、手伝ってくれる？<br>お薬が足りなくなっちゃって…
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01C109_070043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あっ、はい！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_070044")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 1.0)
wait_time(1.0)
show_image("101010140", 0, 0, BLACK_WHITE_TIME,FALSE,FALSE)
set_scale_image(20,20)
fadein(1.0)
wait_time(1.0)
-- ▲直接出力
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
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
