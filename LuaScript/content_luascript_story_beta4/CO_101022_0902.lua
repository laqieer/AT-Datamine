-- このluaスクリプトは、CO_101022_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110081_01","110081_01_h")
Include("content_adv_advsmall_110081_01","Template110081_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110081_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110081_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_004)
	InitializeTemplateRandomCamera110081_01()
	InitializeTemplate110081_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Painful2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110081)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:クラスのみんなにも手伝ってもらったけどそれらしき情報は集められてないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:モルドレッドに声かけてきたあの男の居場所もわからないし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020003")

-- ▼直接出力
PlayPartVoice("モルドレッド", "悩む")
-- ▲直接出力

	--★★モルドレッド★★:そもそも手がかりがほとんどねえからな希望があるとすれば…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:すれば？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:向こうがまたこっちにすり寄ってくる、だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:俺たちが調査してることがバレたら逃げられないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020007")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:それはどうだろうな今のままなら逃げる理由は少ない
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020008")


	--★★モルドレッド★★:こっちは未だにヤツの名前もわからねえどころかほとんど情報を得られていねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020009")


	--★★モルドレッド★★:告発すらできねえんだむしろ、わざわざ逃げるほうが怪しくなる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:それに…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:向こうにとっても都合はいいはずだぜ欲しかった飾りが自分を探してるのはな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020012")

	open_select_window_tag(Actor001,"Normal","CO_101022_09020014","CO_101022_09020015")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:擁立できるものさえ手に入れば黒幕は得をするってことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:わかってきたじゃねーか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020018")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、手に入っても飾れなきゃ意味はなくないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020019")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:その判断は手に入れたあとにすればいい
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:このままずっと進展なしで永久に見つけられないなんてことないよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020022")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:えらく消極的だな。最後まで付き合うってオレに言ったてめえはどこ行ったよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020023")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ここまで手がかりが得られないとは思ってなかったからさ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020024")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:本当に、見つかるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020026")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:釣り針は垂らしたんだあとは待つしかねえだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なあ、ちょっといいか？聞きたいことがあるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020031")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:なんだよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020032")


	--★★ノワール★★:いろんな人があんたはアーサーを嫌ってるって言ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:正直俺も最初はそう思ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020035")


	--★★ノワール★★:でもあんたはアーサーへの侮辱に怒りアーサーへの反感を煽るウワサを否定してる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020036")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:本当のあんたはどっちなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:オレはな、GSが嫌いなんだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020039")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020041")

-- ▼直接出力
bgm_play("BGM_ADV_Painful2")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定3")
-- ▲直接出力

	--★★モルドレッド★★:青春だ絆だと甘い言葉で煽り立て誰かに犠牲を強いてたアーサーも嫌いだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020043")


	--★★モルドレッド★★:だが、誰かを犠牲にしなけりゃ誰も守ることができねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:この世界はそういうクソみたいなシステムになってる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020045")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:本当のオレはどっちか、か…どっちなんだろうな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020047")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:オレはアーサーが嫌いだだが…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020048")


	--★★モルドレッド★★:ヤロウはヤロウで苦悩があったんだろうと理解してるつもりだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020050")

-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:ノワール。アーサーを見て奴が苦悩してると思ったことは？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020051")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:しばらく前まではなかったアーサーはいつも明るくて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:誰かを、みんなを励ましてくれる明るくて強い人だったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:そうだヤロウは常にそうあらんとした
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020054")


	--★★モルドレッド★★:王は苦悩を見せられないなぜなら王が苦悩すれば民は惑うからだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020056")


	--★★モルドレッド★★:故にどんな苦悩を抱えていようともそれを表に出してはならない
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020057")


	--★★モルドレッド★★:王は常に堂々と振る舞いその口から語られる未来は
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020058")


	--★★モルドレッド★★:明るくなければならない希望が無ければならない
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:――その目に映る未来がどれほど絶望に満ちていようともな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020060")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:アーサーには…絶望の未来が見えてた…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020062")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:さぁなオレはアーサーじゃねえから知らねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:だがヤロウも能天気に王をやってたわけではねえだろうよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020064")

	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーは俺が知らないことを知ってるようだった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020065")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:俺が知らない本当を…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020066")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:そして、多くの人間が知らない本当をな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020068")


	--★★ノワール★★:苦悩、してたのかな。アーサーは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020070")


	--★★モルドレッド★★:オレは、今のアーサーはヤロウの苦悩の表れだと思っている
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020073")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:苦悩して、苦悩して苦悩して…その先で決意した
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020074")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:だから、ああなったオレはそう思ってる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020075")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:苦悩に、耐えられなくなって…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020077")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:そこまでは、わからねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020078")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
-- ▲直接出力

	--★★モルドレッド★★:正直に言うとなオレはアーサーこそが理想の王だと思っていた
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020080")


	--★★モルドレッド★★:どれほどの苦悩があれど、それを漏らさず人々を導く者として希望を与え続ける
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020081")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★モルドレッド★★:皆が思い描く『理想の王』の体現者だとよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020082")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:確かに…こんなことになる前の学園にいた頃のアーサーは俺の目にもそう映った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020083")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:そうだ。とてつもなく本当にとてつもなく気に入らねえが
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020084")


	--★★モルドレッド★★:あの甘い言葉を並べる男こそが理想の王だとオレは認めていた
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020085")


	--★★モルドレッド★★:苦悩を隠し、すべてを背負い臣民のために身を尽くす王
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020086")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルドレッド★★:人々が求める王の姿を見せその裏で最善策を求めてもがき続ける
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020087")

-- ▼直接出力
PlayPartVoice("モルドレッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:そういう…孤独な王だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020088")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:苦しい道だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020089")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★モルドレッド★★:ああ、そうだだが、それこそが王の道であり…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020090")


	--★★モルドレッド★★:オレの理想たるアーサーが歩んでいた道だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_09020091")

	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、今のアーサーは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_09020093")

-- ▼直接出力
local trustParam = set_communication_rankup("モルドレッド_コミュランク", "モルドレッド_親密度")
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
preload_sound("BGM_ADV_Painful2")
	InitializeLoad_Preload()
	load_area_scene_preload(110081)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110081_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
