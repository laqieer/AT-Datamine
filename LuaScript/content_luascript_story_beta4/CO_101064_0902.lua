-- このluaスクリプトは、CO_101064_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Smile")

	--★★リアム★★:今日はここまでにしておきましょうか<br>ノワールさん、お疲れ様でした
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:…なあ。本当に黒牙団を<br>放っといていいのか、リアムさん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020003")

	change_face(Actor002,"Normal")

	--★★リアム★★:今の私には関係のないことです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020004")


	--★★ノワール★★:その割にはすっきりしてない顔だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020005")


	--★★ノワール★★:本当は気になってるんだろ？<br>昔の仲間や黒牙団のこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020006")

	PlayAction(Actor002,"to  Std_No")

	--★★リアム★★:気になっていないと言えば嘘になります<br>しかし、今の私は司祭のリアムです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020008")


	--★★リアム★★:黒牙団のリーダーだった<br>あの頃に戻るわけにはいかないのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020009")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん…<br>そもそもリアムさんはどうして司祭に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:やっぱり、先生に憧れたからか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:そうですね<br>それが一番大きな理由でしょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020012")


	--★★リアム★★:当時、教会には多くの人が訪れ<br>先生に悩みを相談していました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020013")


	--★★リアム★★:そのなかには私と同じように世の中を憎み<br>自暴自棄になっている者もいましたが
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020014")


	--★★リアム★★:先生はそうした人たちとも粘り強く<br>対話を重ね、最後には立ち直らせていました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020015")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:それは…すごいな<br>俺なんて話を聞くだけでも大変だったのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020016")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:先生はよくおっしゃっていました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020017")


	--★★リアム★★:日々愛情をもって丁寧に接すれば<br>必ず相手は応えてくれる
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020018")


	--★★リアム★★:相手が人間であろうと植物であろうと<br>それは変わらない
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020019")


	--★★リアム★★:大切なのは他者に寄り添う心なのだと
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020020")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★リアム★★:口で言うのは簡単ですが<br>誰にでもできることではありません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020022")

	change_face(Actor002,"Normal")

	--★★リアム★★:それでも、私ならきっとできると<br>先生はそう言ってくださいました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:その言葉を聞いて<br>私は司祭になることを決意したのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020024")

	open_select_window_tag(Actor001,"Normal","CO_101064_09020026","CO_101064_09020027")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Smile")

	--★★ノワール★★:きっと喜んでいるだろうな、先生は
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020029")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:リアムさんが自分と同じ道を進んでくれたこと<br>…いや、リアムさんが更生してくれたことを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020030")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★リアム★★:…そう、だといいのですが
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、そのあとは<br>黒牙団の仲間とは会ってないのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:ええ<br>ほとんどの者の行方が知れません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020034")

	change_face(Actor002,"Sad")

	--★★リアム★★:私が言えた義理かはわかりませんが…<br>生きていてくれることを願っています
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020035")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:けど、寄り添う心が大事なら<br>昔の仲間に寄り添うことも必要じゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020037")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★リアム★★:そういう考えかたもあるかもしれません<br>しかし、今回ばかりはできないのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020038")


	--★★リアム★★:あれは、司祭見習いになって<br>しばらく経った頃のことでした
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020039")


	--★★リアム★★:私と先生は備品の補充をするために<br>街に出ていたのですが
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020040")

	change_face(Actor002,"Sad")

	--★★リアム★★:その場面を、かつて黒牙団を襲った<br>傭兵のひとりに見つかってしまったのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020041")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★リアム★★:その傭兵はナイフを片手に<br>私に背後から襲いかかってきました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020042")

	change_face(Actor002,"Normal")

	--★★リアム★★:隣にいた先生はいちはやく<br>それに気づき、とっさに私をかばって…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020043")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…そういうことだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020044")


	--★★リアム★★:私が黒牙団のリーダーなどしていなければ<br>先生が亡くなることもなかったでしょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020045")

	change_face(Actor002,"Anger")

	--★★リアム★★:あのような悲劇を繰り返さないためにも<br>私は過去と決別しなければならないのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020046")

	change_face(Actor001,"Normal")

	--★★ノワール★★:別にさ<br>昔に戻らなくてもいいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020048")

	change_face(Actor002,"Surprise")

	--★★リアム★★:え？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020049")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:黒牙団のリーダーとしてじゃなく<br>司祭のリアムとして街の人や昔の仲間を助ける
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020050")


	--★★ノワール★★:そういう考えかたもあると思うんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020051")

	change_face(Actor002,"Normal")

	--★★リアム★★:それはつまり、先生のように<br>黒牙団を騙る者たちを説得して改心させろと？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020052")


	--★★ノワール★★:それができれば一番いいけど<br>やりかたは他にもあると思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020053")

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ノワール★★:今のリアムさんにしかできないやりかたがさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020054")

	change_face(Actor001,"Normal")

	--★★ノワール★★:大事なのは先生の遺志を継ぐことであって<br>やりかたは違ってもいいんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020055")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★リアム★★:今の、私にしか…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020056")

	change_face(Actor002,"Normal")

	--★★リアム★★:ノワールさん。酒場へ行こうと思うのですが<br>ご同行いただいてもよろしいですか？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_09020058")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_09020059")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ9_3")
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
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
