-- このluaスクリプトは、CO_101061_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_005)
	Camera002 = SetTemplate("Actor002",-71,CharaPos110111_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_002)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
set_pos(Actor002,{0.95,0,-18})
-- ▲直接出力
-- ▼直接出力
load_image("201010200","content_still_20101020_image","201010200_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラロゥ", "挨拶")
-- ▲直接出力

	--★★ラロゥ★★:それで、聞きたいことってなに？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:前に干ばつの被害で困ってる村があるって<br>話しただろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:実は最近、ようやく雨が降って<br>事態が好転しつつあるらしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力

	--★★ラロゥ★★:へー<br>よかったじゃん
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ケイの話によると、村人が昔から伝わる<br>豊穣の儀式をやったらしいんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020006")


	--★★ノワール★★:その儀式に使われた道具は長いあいだ<br>行方知れずで、見つかったのは最近だそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020007")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0050")
-- ▲直接出力

	--★★ノワール★★:その道具ってこの前、俺たちが見つけた<br>あの杯のことじゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0007")
-- ▲直接出力

	--★★ラロゥ★★:そうかも知れないね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラロゥ★★:本物の聖杯じゃないなら<br>持ってても仕方ないって思ってさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラロゥ★★:ロンディニウムの図書館にいた考古学者に<br>売っちゃったんだよね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020011")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力

	--★★ラロゥ★★:結局、二束三文にしかならなかったよ<br>あーあ、疲れただけだったな
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101061_10020014","CO_101061_10020015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:優しいんだな、ラロゥは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020017")

-- ▼直接出力
PlayPartVoice("ラロゥ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:気が向いただけだよ<br>言ったでしょ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020018")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そういうことにしておくよ<br>ありがとうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:だから<br>気が向いただけだってば
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020052")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:素直じゃないな、ラロゥは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020022")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:本当は困ってる人がいると知って<br>放っておけなかったんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020023")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:そう思いたいなら好きにすれば
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020024")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(0.7)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:前にさ<br>叶えたい願いがあるって話したでしょ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ<br>正解は教えてもらえなかったけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラロゥ★★:もしどんな願いでも叶えられるなら<br>世界から貧困をなくしたいんだよね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020028")


	--★★ラロゥ★★:オレは運よく周りの環境に恵まれてたから<br>貧しくてもなんとかなってるけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020029")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:なんとかならない人のほうが<br>世の中多いからさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020030")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:そのために聖杯を探してるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:うん<br>仮に聖杯が願いを叶えられなくても
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020032")


	--★★ラロゥ★★:売ったらすごい金になるはずだからね<br>そしたらその金で貧しい人を助けられるじゃん
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラロゥ★★:そんな簡単に解決できる問題じゃないのは<br>わかってるけどね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020036")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そうか<br>やっぱり俺の見立ては間違ってなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お前は正しい心を持っている、信用できる人間だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020038")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "照れ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:だから、そういうのいいから…あ、今の話<br>他の誰にもしないでよ。恥ずかしいからさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力

	--★★ノワール★★:わかった<br>俺たちふたりだけの秘密だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020040")

-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:…なんか、それはそれで恥ずかしい気がするけど<br>まぁいいや
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:それとさ、ついつい言いそびれちゃったけど<br>護衛してくれてサンキュー
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020042")

-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:街や学園にいるときのボケっとした顔と違って<br>その、わりと恰好よかったよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020043")

-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0058")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:一言余計なんだよ、お前は
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020053")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:でも、まあ、気にしないでくれ<br>騎士たる者、友達や仲間を守るのは当然だからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020044")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:友達や仲間…ね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020045")

-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0057")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？どうした？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラロゥ", "悩む")
-- ▲直接出力

	--★★ラロゥ★★:これからも一緒に聖杯を探すなら<br>もうちょっとマシな呼びかたがあるんじゃない？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020047")


	--★★ラロゥ★★:相棒、とかさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_10020048")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
PlayActionDirect(Actor001,"to  Std_Joy")
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:相棒か…よし、わかった<br>あらためてこれからもよろしくな、相棒
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_10020049")

-- ▼直接出力
CloseTalkWindow()
show_image("201010200", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) 
set_scale_image(0.8,0.8) 
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:うん。よろしく、相棒
	Talk(Actor002,"CHRNAME_LAROU","simple","N","CO_101061_10020050")

-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力

	--★★ラロゥ★★:置いて行かれないように<br>しっかりついてきてよね
	Talk(Actor002,"CHRNAME_LAROU","simple","N","CO_101061_10020051")

-- ▼直接出力
local trustParam = set_communication_rankup("ラロゥ_コミュランク", "ラロゥ_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010200","content_still_20101020_image","201010200_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
