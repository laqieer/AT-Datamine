-- このluaスクリプトは、EA_066_055.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
load_sound("BGM_ADV_LightBrave")

load_image("101010140", "content_still_10101014_image", "101010140_StillImage") -- 黒背景
load_image("101010150", "content_still_10101015_image", "101010150_StillImage") -- 白背景

show_image("101010140", 0, 0, 0, false, false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
hideobj01 = get_object("Npc_501_03_Nbl_Std01_Loop")
set_pos(hideobj01, {0,-20, 0})
hideobj02 = get_object("Npc_001_02_Com_Std01_Loop")
set_pos(hideobj02, {0,-20, 0})
hideobj03 = get_object("Npc_001_03_Bad_Std01")
set_pos(hideobj03, {0,-20, 0})
hideobj04 = get_object("Npc_001_01_Imp_Std02_Loop")
set_pos(hideobj04, {0,-20, 0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101015","001","101015001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
se_play("SE_ADV_MA_01104_25_Earthquake")
wait_time(5.0)

hide_image(3.0)
wait_time(3.0)
PlayPartVoiceDirect("ラロゥ","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラロゥ★★:聖杯も伝説級の武具も<br>結局なにひとつ見つからず収穫ゼロか～
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0550004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0019")
-- ▲直接出力

	--★★クレア★★:収穫ならあったわ<br>ヴォールスが新しい力の使い方を覚えたし
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550005")

	PlayAction(Actor002,"to TakeHand")
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0049")
-- ▲直接出力

	--★★クレア★★:それに、ほら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ラロゥ★★:なにこれ。コイン？
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0550007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0008")
-- ▲直接出力

	--★★クレア★★:聖杯が裂け目に落ちるときに<br>宙を舞って散らばったの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550008")


	--★★クレア★★:多分、あの中に入ってたのね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ラロゥ★★:なんで？
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0550010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★クレア★★:さあ…<br>でもその謎を解くのも面白そうね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550011")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101024_sp_0002_1")
-- ▲直接出力

	--★★ヴォールス★★:というか…<br>いつの間に持ってきたんだ、そんなもの
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ヴォールスが集めるって言ってたから<br>ナイスキャッチでしょ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ヴォールス★★:…ああ。さすがだな
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550014")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0002")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラロゥ★★:結局、あの聖杯は本物だったのかな
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0550015")

	open_select_window_tag(Actor003,"Normal","EA_066_0550017","EA_066_0550018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0038")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:本物かもしれないな<br>　
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550021")


	--★★ヴォールス★★:少なくとも、ただのガラクタではない<br>不思議な力を感じた
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550022")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:…そう、ほんの一瞬――<br>大切な思い出に触れたような――
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0038")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:…一度きりの奇跡でも<br>わたしたちが信じるなら、それは本物になる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:偽物だ<br>俺たちが探して求めていた伝承の聖杯とは違う
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550027")


	--★★ヴォールス★★:だが、別の伝承があるかもしれん<br>俺たちが知らない、別の伝承が
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0038")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:その伝承においては、あの聖杯こそが本物<br>…かもしれないわね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550029")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0033")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:どのみち、今となってはわからないわね<br>真相は地の奥底に沈んでしまったから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550031")


	--★★クレア★★:遺跡も完全に崩れてしまったから<br>取りに行くのは至難の業ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550032")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0025")
-- ▲直接出力

	--★★ラロゥ★★:だよねぇ…あーあ、残念
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0550033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0038")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラロゥ★★:ま、いっか。諦めずにいたらまた<br>どこかで別の聖杯が見つかるかもしれないしね
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0550034")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0033")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:そう頻繁に聖杯に出てこられても困るがな…
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550035")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ラロゥ★★:そう？いいと思うけどな<br>そのときはいっしょに乾杯しようよ
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0550036")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0006")
-- ▲直接出力

	--★★ラロゥ★★:それじゃ、またどこかで会ったらよろしくね
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0550037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_MidFade")

PlayActionDirect(Actor001, "to Wlk")
turn(Actor001, 0, 160, 0, 0.5)
wait_time(0.5)

slidemove(Actor001, 2.32, 0, -3.2, 2.0)
wait_time(2.0)
Hide(Actor001)
setup_small_camera_end()

bgm_play("BGM_ADV_LightBrave")
PlayPartVoiceDirect("ヴォールス","0033")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:…元気だな
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:やりたいことがあると<br>人生に張り合いがあるっていうわよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550040")

	change_face(Actor002,"Smile")

	--★★クレア★★:あなたも身に覚えがあるんじゃない？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550041")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0038")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ヴォールス★★:そうだな。思い出したよ<br>俺は存外、宝探しが好きなようだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550042")


	--★★ヴォールス★★:今回の『聖杯』のように、この世界には<br>まだまだ奇跡が眠っているのかもしれない
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550043")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:俺たちが忘れてしまった――けれど確かに<br>ここにあった『彼女』の想いに触れられるような
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550044")


	--★★ヴォールス★★:そんな奇跡がほかにもあるなら<br>それを探してみたい
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス★★:たとえ世界から『彼女』が喪われていても<br>俺たちが思い出せないとしても
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550046")


	--★★ヴォールス★★:喪われた過去を求めて<br>まだ見ぬ奇跡を探すことで
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550047")


	--★★ヴォールス★★:あいつの寂しさに少しでも<br>寄り添うことが出来るなら――
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550048")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ヴォールス★★:それ以上の宝はない
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0010")
-- ▲直接出力

	--★★クレア★★:進むべき道は見えたみたいね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550051")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:まだぼんやりとだがな
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550052")


	--★★ヴォールス★★:ただ、立ち止まって後ろを向いていても<br>なにも始まらない
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ヴォールス★★:彼らの選択と覚悟に報いるためにも<br>前を向いて、人生を楽しむ――
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550054")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0034")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:きっとそれが…遺された者の――<br>俺のやるべきことなんだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550055")

-- ▼直接出力
CloseTalkWindow()
show_image("101010150", 0, 0, 0.1, false, false)
set_scale_image(20,20)
wait_time(0.3)
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:青春を楽しむのに、遅すぎるということはないぞ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_066_0550057")


	--★★ヴォールス★★:………
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550058")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)

setup_small_camera_end()
voice_play("VO_101025_sp_0002_1")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:それじゃあ…次はどうする？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0550059")

	change_face(Actor003,"Normal")

	--★★ヴォールス★★:そうだな――
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550060")

-- ▼直接出力
PlayActionDirect(Actor003, "to Wlk")
turn(Actor003, 0, 100, 0, 0.3)
wait_time(0.3)

PlayActionDirect(Actor003, "to Std_Loop")
wait_time(1.0)
PlayAction(Actor003,"to  Std_Sad01")
SkipDefaultMotion(Actor003)
PlayPartVoiceDirect("ヴォールス","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ヴォールス★★:…とりあえず、また船に乗るか<br>伝説級の武具と、異国のコインを探しに
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0550061")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_LightBrave")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101015","001","101015001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
