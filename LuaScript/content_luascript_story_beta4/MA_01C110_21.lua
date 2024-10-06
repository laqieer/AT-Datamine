-- このluaスクリプトは、MA_01C110_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114061_01","114061_01_h")
Include("content_adv_advsmall_114061_01","Template114061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_003)
	InitializeTemplateRandomCamera114061_01()
	InitializeTemplate114061_01()
-- ▼直接出力
load_image("MA01C1102101", "content_still_10104003_image", "101040030_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
prop = setup_prop_object(10201020)
off_active(prop)
prop_offset = {0.001,0.005,-0.008,-6.536,3.313,-10.902}
on_parent(prop,Actor001, "Loc_weapon_constrint_R", prop_offset)
off_parent(prop)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Armoury")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,-172.625,0)
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114061)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101021","003","101021003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…不思議だな<br>ここに来たのは久しぶりのはずなのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:なんだか、ついこの間までいたみたいだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力

	--★★ディナタン★★:兄さんも？実は、私も<br>なんでだろうね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:さぁ…今思えばあの森、この湖に<br>雰囲気が少し似ている気がする。だからかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210005")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…そうかもね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ディナタンはなにを持ってきたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210007")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:これ…『不格好なコート』団の徽章
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:ブライアンさんの徽章は私がもらって<br>代わりに私のものをお別れの品にと思って
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうか<br>ブライアン、きっと喜ぶよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210011")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ディナタン★★:兄さんはなにを持ってきたの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210012")

-- ▼直接出力
CloseTalkWindow()
on_active(prop)
on_parent(prop,Actor001, "Loc_weapon_constrint_R", prop_offset)
setup_small_camera_start()
PlayActionDirect(Actor001,"to  Std_Talk")
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…仮面？<br>ブライアンさん、そんなの持ってた？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210014")

	open_select_window_tag(Actor001,"Normal","MA_01C110_210015","MA_01C110_210016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:これは…父さんのものだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210018")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:父…さん…？<br>誰の？…私、たちの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そう。俺たちをずっと守っていてくれた<br>優しい父さんが遺していったものだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:私…父さんのこと…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210021")

	change_face(Actor001,"Normal")

	--★★ノワール★★:大丈夫<br>父さんはわかってくれる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それに今も見守ってくれているから<br>俺とディナタンを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210023")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも…父さんとは<br>ここでお別れしなきゃならない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これは…ブライアンの<br>とても仲の良かった友達のものだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210026")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:…？<br>私も知っている人？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210027")

	change_face(Actor001,"Sad")

	--★★ノワール★★:知っているけど知らない<br>…そんな人かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210028")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…どういう、こと？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いつか話せるときが来たら話すよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210030")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:もう！<br>ランス兄ちゃんみたいなこと言って
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210031")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…私たち、忘れてていいのかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210033")


	--★★ディナタン★★:忘れてしまうのは仕方ないことなのかな<br>この世界で
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210034")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…わからない<br>けど、仕方しかたないことなんだ。きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210035")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:…うん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210036")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:どこかにほんのちょっとでも<br>記憶は残ってないのかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210038")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:どこかにきっと思い出になって残ってるよ<br>この湖みたいに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:…そうだといいな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:だから今はこれを返そう<br>俺たちの想い出のこの湖に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210041")

-- ▼直接出力
CloseTalkWindow() 
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("MA01C1102101", 0.0, 0.0,0,true,false)
setup_small_camera_end()
off_active(prop)
off_parent(prop)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:さよなら…ありがとう、ブライアンさん
	Talk(Actor002,"CHRNAME_DINATAN","speech","N","MA_01C110_210043")


	--★★ノワール★★:さよなら、ブライアン<br>さよなら…父さん
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C110_210044")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
--エフェクト終了
hide_image()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
  setup_small_camera_start(Camera001)
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:父、さん――…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210046")

-- ▼直接出力
CloseTalkWindow() 
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Armoury")
-- ▲直接出力

	--★★ブルーノ★★:本当に大切なことをお前たちに<br>教えられなかった
	Talk(Actor003,"CHRNAME_BRUNO","simple","N","MA_01C110_210048")


	--★★ブルーノ★★:何故お前が継承者に選ばれたのか<br>何故お前でなければならなかったのか
	Talk(Actor003,"CHRNAME_BRUNO","simple","N","MA_01C110_210049")


	--★★ブルーノ★★:すべては妖精の願い<br>いや――…
	Talk(Actor003,"CHRNAME_BRUNO","simple","N","MA_01C110_210050")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Anger")

	--★★ディナタン★★:…さん、兄さん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:へっ！？ど、どうしたディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210053")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:どうした、はこっちの台詞だよ！<br>湖を覗き込んだまま全然動かないんだもん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210054")


	--★★ディナタン★★:いったいどうしたの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210056")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや…なんでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_210057")

-- ▼直接出力
 setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:もう、しっかりしてよね。兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_210058")

-- ▼直接出力
 setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（今のは――…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01C110_210060")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA01C1102101", "content_still_10104003_image", "101040030_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
setup_prop_object_preload(10201020)
prop_offset = {0.001,0.005,-0.008,-6.536,3.313,-10.902}
preload_sound("BGM_ADV_Armoury")
preload_sound("BGM_Area_Acoustic")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114061)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101021","003","101021003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
