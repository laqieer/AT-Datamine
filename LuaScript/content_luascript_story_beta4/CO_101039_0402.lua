-- このluaスクリプトは、CO_101039_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110171_08","110171_08_h")
Include("content_adv_advsmall_110171_08","Template110171_08_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110171_08_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110171_08,CameraPos110171_08_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110171_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110171_08,CameraPos110171_08_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110171_08_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110171_08,CameraPos110171_08_003)
	InitializeTemplateRandomCamera110171_08()
	InitializeTemplate110171_08()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110171)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれ？<br>そこって、ローラの席だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:うん、そうだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020003")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにかローラのことで悩んでるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:ローラがルーシャスくんの所に行った理由ってさ<br>きっと私に原因があるよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:私がルーシャスくんの所に行くか行かないか<br>煮え切らない態度をしてたから、愛想を尽かして
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_04020009","CO_101039_04020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それは少し違うと思う<br>ローラはフレンのために行ったんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020012")

	change_face(Actor002,"Surprise")

	--★★フレン★★:私のために？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園のこと、ルーシャスのこと、ローラのこと<br>フレンは全部が丸く収まるように悩んでる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:きっと、今もまだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★フレン★★:…うん
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:学園とルーシャスを繋ぐ手伝いをしに行ったのさ<br>優しいフレンのために、ローラは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020017")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:そうなのかな<br>優しいね、ローラは
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:悩むくらいなら動き出そう<br>普段のフレンはそうするって伝えたかったのかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★フレン★★:自分でも戸惑ってるんだ<br>普段の私ならそうできたはずなのにね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、それってフレンが<br>学園のことを大切に思ってくれてる証拠だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はフレンのその思いをすごく嬉しく感じてるし<br>ローラもそれを尊重しての行動だったはずさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★フレン★★:そっか。早く普段の私に戻らないと<br>ローラに怒られちゃうね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020024")

	goto Block1end

::Block1end::
	change_face(Actor002,"Smile")

	--★★フレン★★:ノワールくん、励ましてくれてありがとう
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:どういたしまして<br>今のフレンの気持ち、なんとなくわかるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020027")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺にも妹がいるし<br>妹と離れ離れになったときのことを考えたら…さ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:あ、そっか
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020029")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:でも…こっちがどんなに心配してても<br>妹は案外何とも思ってなかったりするぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020031")

-- ▼直接出力
 --リオネス登場のためカメラを固定
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ふふふっ<br>そういうもんかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020032")

-- ▼直接出力
se_play("SE_ADV_MA_01B112_12_Door_Open")
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス","挨拶")
-- ▲直接出力

	--★★リオネス★★:失礼するぞー！
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","CO_101039_04020034")

-- ▼直接出力
 --リオネス登場&名前変更
CloseTalkWindow()
Appear(Actor003)
--リオネス,CHRNAME_LYONESS @名前変更
wait_time(0.5)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:いたいた。おーい、ローラ！<br>…って、お姉ちゃんのほうか
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101039_04020036")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:リオネス？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020037")

	change_face(Actor002,"Surprise")

	--★★フレン★★:どうしたの？<br>ローラになにか用？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020038")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★リオネス★★:こないだ食堂の新メニューを試食してるときに<br>ちょっと服にこぼしちゃったんだ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101039_04020039")


	--★★リオネス★★:そしたら近くにいたローラが<br>このハンカチで拭いてくれてさ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101039_04020040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リオネス★★:綺麗な刺繍がしてあるし<br>きっと手芸サークルで作った大事なものだろ？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101039_04020041")

-- ▼直接出力
PlayPartVoice("リオネス","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:あたしの服なんでどうでもよかったのにな～<br>やっぱりローラはいいヤツだ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101039_04020042")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★リオネス★★:直接渡したかったんだけど、今から用事あってさ<br>お姉ちゃんから返しといてもらえるか？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101039_04020044")


	--★★フレン★★:う、うん
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020046")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:それじゃ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101039_04020047")


	--★★フレン★★:あっ、待って！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力

	--★★フレン★★:ねぇ、リオネスはローラと仲がいいの？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020051")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス","肯定3")
-- ▲直接出力

	--★★リオネス★★:うん<br>食堂で会ったときとか、よく話をするぞ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101039_04020052")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス","笑い")
-- ▲直接出力

	--★★リオネス★★:ローラは大好きだ<br>一緒に話してると落ち着くからな
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101039_04020053")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
setup_small_camera_start()
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力

	--★★フレン★★:意外なローラの交友関係を<br>発見しちゃった
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020055")


	--★★フレン★★:他のクラスの子とも話すことがあるなんて
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_04020058","CO_101039_04020059")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リオネスだけじゃない<br>俺もローラのことは大好きだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020061")

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:ノワールくん、ローラのこと好きだったんだ…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020062")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020063")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:違うぞ？<br>そういう意味じゃなくって、友達として！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020064")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ふふっ<br>私、別になにも聞いてないよ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020065")

-- ▼直接出力
PlayPartVoice("フレン", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:そうなんだ、ふ～ん<br>ノワールくんがねえ…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020066")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:だから違うんだって！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020067")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなに意外なことなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020069")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:うん<br>あの子、人見知りだから
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020070")

	change_face(Actor002,"Surprise")

	--★★フレン★★:ううん。私が勝手にローラは<br>人見知りだと思い込んでただけなのかも
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020071")

	change_face(Actor002,"Smile")

	--★★フレン★★:ローラも成長してるんだね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020073")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ふふっ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020075")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:なんだか嬉しそうだな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020076")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:そりゃ嬉しいよ！<br>妹に友達がいっぱいいるってわかったんだもん！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020077")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力

	--★★フレン★★:なんか元気出て来たぞー！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020078")


	--★★フレン★★:よーし、陸上部に行って走ってこよっと！<br>ノワールくんも一緒にどう？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04020079")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:いいね<br>付き合うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04020080")

-- ▼直接出力
local trustParam = set_communication_rankup("フレン_コミュランク", "フレン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
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
	InitializeLoad_Preload()
	load_area_scene_preload(110171)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110171_08)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
